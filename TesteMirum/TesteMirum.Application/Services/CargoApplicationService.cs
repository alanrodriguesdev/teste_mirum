using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMirum.Application.Interfaces;
using TesteMirum.Application.ViewModels.Cargo;
using TesteMirum.Domain.Interfaces;
using TesteMirum.Domain.Model;

namespace TesteMirum.Application.Services
{
    public class CargoApplicationService : ICargoApplicationService
    {
        private readonly ICargoService _cargoService;
        public CargoApplicationService(
            ICargoService cargoService
            )
        {
            this._cargoService = cargoService;
        }

        public void AddCargo(CargoViewModel cargoView)
        {
            _cargoService.AddCargo(Mapper.Map<CargoViewModel, Cargo>(cargoView));
        }
        public IEnumerable<CargoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Cargo>, IEnumerable<CargoViewModel>>(_cargoService.GetAll());
        }
        public void EditarCargo(CargoViewModel editarCargo)
        {
            _cargoService.EditarCargo(Mapper.Map<CargoViewModel, Cargo>(editarCargo));
        }

        public void Excluir(int id)
        {
            _cargoService.Excluir(id);
        }
    }
}
