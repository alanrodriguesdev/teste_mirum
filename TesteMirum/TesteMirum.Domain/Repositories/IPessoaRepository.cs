using System;
using System.Collections.Generic;
using TesteMirum.Domain.Model;

namespace TesteMirum.Domain.Repositories
{
    public interface IPessoaRepository 
    {
        void AddPessoa(Pessoa pessoa);
        IEnumerable<PessoaLista> GetAll();
        void Excluir(int id);
        void EditarPessoa(Pessoa editarPessoa);
        int GetQuantPessoasByCargoId(int cargoId);
        void ExcluirPessoaByCargoId(int cargoId);
        IEnumerable<PessoaLista> GetByFilter(int? Cod_Pessoa);
    }
}
