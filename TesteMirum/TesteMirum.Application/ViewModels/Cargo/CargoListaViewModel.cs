using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMirum.Application.ViewModels.Cargo
{
    public class CargoListaViewModel
    {
        public int Id { get; set; }
        public string Cargo_Nome { get; set; }
        public decimal Salario_Base { get; set; }
        public string Pessoa_Nome { get; set; }
    }
}
