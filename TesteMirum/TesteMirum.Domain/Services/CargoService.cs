using System;
using System.Collections.Generic;
using TesteMirum.Domain.Interfaces;
using TesteMirum.Domain.Model;
using TesteMirum.Domain.Repositories;

namespace TesteMirum.Domain.Services
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _cargoRepository;
        public CargoService(
            ICargoRepository cargoRepository
            )
        {
            this._cargoRepository = cargoRepository;
        }

        public void AddCargo(Cargo cargo)
        {
            _cargoRepository.AddCargo(cargo);
        }

        public void EditarCargo(Cargo editarCargo)
        {
            _cargoRepository.EditarCargo(editarCargo);
        }
        public IEnumerable<Cargo> GetAll()
        {
            return _cargoRepository.GetAll();
        }
        public void Excluir(int id)
        {
            _cargoRepository.Excluir(id);
        }
    }
}
