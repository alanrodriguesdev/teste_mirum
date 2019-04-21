namespace TesteMirum.Data.Infra.Repositories
{
    public partial class PessoaRepository
    {
        #region SELECT's
        private const string selectAllPessoa = @"
            SELECT 
                p.Id
                ,p.Nome
                ,p.Rg
                ,p.Email   
                ,p.Cargo_Id
                ,c.Cargo
            FROM Pessoa p
            INNER JOIN Cargo c ON p.Cargo_Id = c.Id
        ";
        private const string selectQuantPessoaByCargoId = @"
            SELECT Id FROM Pessoa WHERE Cargo_Id = @cargoId
        ";
        #endregion
        #region INSERT's
        private const string insertPessoa = @"
           INSERT INTO Pessoa 
            (
                Nome
                ,Rg
                ,Email
                ,Cargo_Id
            )
            VALUES
            (
                @Nome
                ,@Rg
                ,@Email
                ,@Cargo_Id
            )
                    ";
        #endregion
        #region UPDATE's
        private const string updatePessoa = @"
            UPDATE Pessoa SET
                Nome = @Nome
                ,Rg = @Rg
                ,Email = @Email
                ,Cargo_Id = @Cargo_Id
            WHERE Id = @Id
        ";
        #endregion
        #region DELETE's
        private const string deletePessoa = @"
            DELETE FROM Pessoa
                WHERE Id = @id
        ";
        private const string deleteExcluirPessoaByCargoId = @"
            DELETE FROM Pessoa
                WHERE Cargo_Id = @cargoId
        ";
        #endregion
    }
}
