using System.Collections.Generic;
using TesteMirum.Domain.Model;

namespace TesteMirum.Domain.Interfaces
{
    public interface IPessoaService
    {
        void AddPessoa(Pessoa pessoa);
        IEnumerable<PessoaLista> GetAll();
        void Excluir(int id);
        void EditarPessoa(Pessoa editarPessoa);
        int GetQuantPessoasByCargoId(int cargoId);
        void ExcluirPessoaByCargoId(int cargoId);
    }
}
