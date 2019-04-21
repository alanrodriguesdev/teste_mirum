using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMirum.Application.ViewModels.Cargo
{
    public class CargoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Cargo é obrigatório.", AllowEmptyStrings = false)]
        public string Cargo_Nome { get; set; }
        [Required(ErrorMessage = "O Salário Base é obrigatório.", AllowEmptyStrings = false)]
        public decimal Salario_Base { get; set; }
    }
}
