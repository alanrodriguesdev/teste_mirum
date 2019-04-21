using AutoMapper;
using TesteMirum.Application.ViewModels.Cargo;
using TesteMirum.Application.ViewModels.Pessoa;
using TesteMirum.Domain.Model;

namespace TesteMirum.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {      
        public  ViewModelToDomainMappingProfile()
        {
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<CargoViewModel, Cargo>();
            CreateMap<PessoaListaViewModel, PessoaLista>();
            CreateMap<CargoListaViewModel, CargoLista>();
        }
    }
}
