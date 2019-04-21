using System.Collections.Generic;
using TesteMirum.Application.ViewModels.Pessoa;

namespace TesteMirum.Application.Interfaces
{
    public interface IPessoaApplicationService
    {
        void AddPessoa(PessoaViewModel pessoaView);
        IEnumerable<PessoaListaViewModel> GetAll();
        void Excluir(int id);
        void ExcluirPessoaByCargoId(int cargoId);
        void EditarPessoa(PessoaViewModel editarPessoa);
        int GetQuantPessoasByCargoId(int cargoId);
    }
}
