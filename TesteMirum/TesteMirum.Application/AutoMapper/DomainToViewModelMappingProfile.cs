using AutoMapper;
using TesteMirum.Application.ViewModels.Cargo;
using TesteMirum.Application.ViewModels.Pessoa;
using TesteMirum.Domain.Model;

namespace TesteMirum.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Cargo, CargoViewModel>();
            CreateMap<PessoaLista, PessoaListaViewModel>();
            CreateMap<CargoLista, CargoListaViewModel>();

            
        }
    }
}
