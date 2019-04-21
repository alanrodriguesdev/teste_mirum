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

        public IEnumerable<CargoLista> GetByFilter(int? codCargo)
        {
            using (var conn = ConnectionFactory.TesteMirumDataBaseOpen())
            {
                var query = selectByFilter;

                if (codCargo != null)
                    query = query.Replace("@parm", "AND (c.Id = @codCargo)");

                query = query.Replace("@parm", "");
                return conn.Query<CargoLista>(query,new { codCargo }).AsEnumerable();
            };
        }
    }
}
