using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMirum.Data.Infra.Repositories
{
    public partial class CargoRepository
    {
        #region SELECT's
        private const string selectAllCargos = @"
            SELECT 
                Id
                ,Cargo Cargo_Nome
                ,Salario_Base
            FROM Cargo
        ";
        private const string selectByFilter = @"
            SELECT 
                c.Id
                ,c.Cargo Cargo_Nome
                ,c.Salario_Base
                ,p.Nome Pessoa_Nome
            FROM Cargo c
            INNER JOIN Pessoa p ON c.Id = p.Cargo_Id
            WHERE 1=1
                @parm
        ";
        #endregion
        #region INSERT's
        private const string insertCargo = @"
             INSERT INTO Cargo 
            (
                Cargo
                ,Salario_Base
            )
            VALUES
            (
                @Cargo_Nome
                ,@Salario_Base
            )
        ";
        #endregion
        #region UPDATE's
        private const string updateCargo = @"
            UPDATE Cargo SET
                Cargo = @Cargo_Nome
                ,Salario_Base = @Salario_Base
            WHERE Id = @Id
        ";
        #endregion
        #region DELETE's
        private const string deleteCargo = @"
            DELETE FROM Cargo
                WHERE Id = @id
        ";
        #endregion
    }
}
