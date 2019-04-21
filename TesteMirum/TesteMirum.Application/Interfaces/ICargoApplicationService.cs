using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMirum.Application.ViewModels.Cargo;

namespace TesteMirum.Application.Interfaces
{
    public interface ICargoApplicationService
    {
        IEnumerable<CargoViewModel> GetAll();
        IEnumerable<CargoListaViewModel> GetByFilter(string Cod_Cargo = null);
        void AddCargo(CargoViewModel cargoView);
        void EditarCargo(CargoViewModel editarCargo);
        void Excluir(int id);
    }
}
