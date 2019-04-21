using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMirum.Domain.Model;
using TesteMirum.Domain.Repositories;

namespace TesteMirum.Data.Infra.Repositories
{
    public partial class CargoRepository 
        : ICargoRepository
    {
        public void AddCargo(Cargo cargo)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                conn.Execute(insertCargo, cargo);
            };
        }
        public IEnumerable<Cargo> GetAll()
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                return conn.Query<Cargo>(selectAllCargos).AsEnumerable();
            };
        }
        public void EditarCargo(Cargo editarCargo)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                conn.Execute(updateCargo, editarCargo);
            };
        }

        public void Excluir(int id)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                conn.Execute(deleteCargo, new { id });
            };
        }

    }
}
