using Autofac;
using Autofac.Features.ResolveAnything;
using Autofac.Integration.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using TesteMirum.Application.Services;
using TesteMirum.Data.Infra.Repositories;
using TesteMirum.Domain.Services;

namespace TesteMirum.Ioc
{
    public class MvcAutofacConfig
    {
        public static IContainer RegisterAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());


            var currentAssembly = Assembly.GetExecutingAssembly();
            var callerAssemblies = new StackTrace().GetFrames()
                .Select(x => x.GetMethod().ReflectedType.Assembly).Distinct()
                .Where(x => x.GetReferencedAssemblies().Any(y => y.FullName == currentAssembly.FullName));
            var initialAssembly = callerAssemblies.Last();

            builder.RegisterControllers(initialAssembly);
            builder.RegisterAssemblyModules(initialAssembly);
            builder.RegisterModelBinders(initialAssembly);
            builder.RegisterModelBinderProvider();

            builder.RegisterAssemblyTypes(typeof(PessoaService).Assembly).Where(p => p.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(PessoaApplicationService).Assembly).Where(p => p.Name.EndsWith("ApplicationService")).AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(PessoaRepository).Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerRequest();
           

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }
    }
}
