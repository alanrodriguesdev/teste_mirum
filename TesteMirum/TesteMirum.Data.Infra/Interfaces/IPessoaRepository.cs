using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMirum.Domain.Model;

namespace TesteMirum.Data.Infra.Interfaces
{
    public interface IPessoaRepository
    {
        void AddPessoa(Pessoa pessoa);
    }
}
