using System;
using System.Collections.Generic;
using TesteMirum.Domain.Interfaces;
using TesteMirum.Domain.Model;
using TesteMirum.Domain.Repositories;

namespace TesteMirum.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        public void AddPessoa(Pessoa pessoa)
        {            
            _pessoaRepository.AddPessoa(pessoa);
        }
        public IEnumerable<PessoaLista> GetAll()
        {
            return _pessoaRepository.GetAll();
        }

        public void Excluir(int id)
        {           
            _pessoaRepository.Excluir(id);
        }

        public void EditarPessoa(Pessoa editarPessoa)
        {           
           _pessoaRepository.EditarPessoa(editarPessoa);
        }

        public int GetQuantPessoasByCargoId(int cargoId)
        {
            return _pessoaRepository.GetQuantPessoasByCargoId(cargoId);
        }

        public void ExcluirPessoaByCargoId(int cargoId)
        {
           _pessoaRepository.ExcluirPessoaByCargoId(cargoId);
        }
    }
}
