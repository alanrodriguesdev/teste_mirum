using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMirum.Domain.Model;

namespace TesteMirum.Domain.Interfaces
{
    public interface ICargoService
    {
        IEnumerable<Cargo> GetAll();
        void AddCargo(Cargo cargo);
        void EditarCargo(Cargo editarCargo);
        void Excluir(int id);
    }
}
