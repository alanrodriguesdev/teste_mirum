using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using TesteMirum.Domain.Model;
using TesteMirum.Domain.Repositories;

namespace TesteMirum.Data.Infra.Repositories
{
    public partial class PessoaRepository
        : IPessoaRepository
    {
      
        public void AddPessoa(Pessoa pessoa)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                conn.Execute(insertPessoa, pessoa);
            };
        }

        //Exemplo de pesquisa feita com Entity
        public IEnumerable<PessoaLista> GetAll()
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                return conn.Query<PessoaLista>(selectAllPessoa).AsEnumerable();
            };
        }
        public void Excluir(int id)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                conn.Execute(deletePessoa, new { id });
            };
        }

        public void EditarPessoa(Pessoa editarPessoa)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                conn.Execute(updatePessoa, editarPessoa);
            };
        }

        public int GetQuantPessoasByCargoId(int cargoId)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                return conn.Query<int>(selectQuantPessoaByCargoId, new { cargoId }).Count();
            };
        }

        public void ExcluirPessoaByCargoId(int cargoId)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                conn.Execute(deleteExcluirPessoaByCargoId, new { cargoId });
            };
        }

    }
}
