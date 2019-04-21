using System;
using System.Collections.Generic;
using TesteMirum.Domain.Model;

namespace TesteMirum.Domain.Repositories
{
    public interface ICargoRepository 
    {
        IEnumerable<Cargo> GetAll();
        void AddCargo(Cargo cargo);
        void EditarCargo(Cargo editarCargo);
        void Excluir(int id);
        IEnumerable<CargoLista> GetByFilter(int? codCargo);
    }
}
