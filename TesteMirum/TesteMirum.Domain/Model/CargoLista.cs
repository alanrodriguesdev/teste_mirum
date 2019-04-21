using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMirum.Domain.Model
{
    public class CargoLista
    {
        public int Id { get; set; }
        public string Cargo_Nome { get; set; }
        public decimal Salario_Base { get; set; }
        public string Pessoa_Nome { get; set; }
    }
}
