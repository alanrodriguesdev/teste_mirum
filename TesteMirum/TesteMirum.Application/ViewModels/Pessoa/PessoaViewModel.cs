using System.ComponentModel.DataAnnotations;

namespace TesteMirum.Application.ViewModels.Pessoa
{
    public class PessoaViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome da pessoa é obrigatório.", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Rg  é obrigatório.", AllowEmptyStrings = false)]
        public string Rg { get; set; }
        [Required(ErrorMessage = "O Email  é obrigatório", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Endereço de email inválido.")]
        public string Email { get; set; }
        public int Cargo_Id { get; set; }
    }
}