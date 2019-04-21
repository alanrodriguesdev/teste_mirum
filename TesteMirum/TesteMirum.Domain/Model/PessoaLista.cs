using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMirum.Domain.Model
{
    public class PessoaLista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public int Cargo_Id { get; set; }
        public string Cargo { get; set; }
    }
}
