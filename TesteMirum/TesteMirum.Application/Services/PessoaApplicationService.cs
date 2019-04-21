using System;
using System.Collections.Generic;
using AutoMapper;
using TesteMirum.Application.Interfaces;
using TesteMirum.Application.ViewModels.Pessoa;
using TesteMirum.Domain.Interfaces;
using TesteMirum.Domain.Model;

namespace TesteMirum.Application.Services
{
    public class PessoaApplicationService : IPessoaApplicationService
    {
        private readonly IPessoaService _pessoaService;
        public PessoaApplicationService(
            IPessoaService pessoaService          
            )
        {
            _pessoaService = pessoaService;
        }
        public void AddPessoa(PessoaViewModel pessoaView)
        {
            _pessoaService.AddPessoa(Mapper.Map<PessoaViewModel,Pessoa>(pessoaView));          
        }
        public IEnumerable<PessoaListaViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<PessoaLista>, IEnumerable<PessoaListaViewModel>>(_pessoaService.GetAll());
        }
        public void Excluir(int id)
        {
            _pessoaService.Excluir(id);
        }

        public void EditarPessoa(PessoaViewModel editarPessoa)
        {
            _pessoaService.EditarPessoa(Mapper.Map<PessoaViewModel,Pessoa>(editarPessoa));
        }

        public int GetQuantPessoasByCargoId(int cargoId)
        {
           return _pessoaService.GetQuantPessoasByCargoId(cargoId);
        }

        public void ExcluirPessoaByCargoId(int cargoId)
        {
            _pessoaService.ExcluirPessoaByCargoId(cargoId);
        }

        public IEnumerable<PessoaListaViewModel> GetByFilter(string Cod_Pessoa)
        {
            int? codPessoa =null;
            if (!String.IsNullOrEmpty(Cod_Pessoa))
            {
                var isNumeric = int.TryParse(Cod_Pessoa, out int n);

                if (isNumeric)
                    codPessoa = Convert.ToInt32(Cod_Pessoa);
                else
                    codPessoa = null;                
            }
            return Mapper.Map<IEnumerable<PessoaLista>, IEnumerable<PessoaListaViewModel>>(_pessoaService.GetByFilter(codPessoa));
        }
    }
}
