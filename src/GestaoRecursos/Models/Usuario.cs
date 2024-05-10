using System.ComponentModel.DataAnnotations;

namespace GestaoRecursos.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Obrigatório fornecer o nome.")]
        public string Nome { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório fornecer um email.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório fornecer senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public PerfilUsuario? PerfilUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório definir o campo de ativo.")]
        public bool Ativo { get; set; }

        [Display(Name = "Data de criação")]
        public DateTime? DataCriacao { get; set; }

        [Display(Name = "Data de alteração")]
        public DateTime? DataAlteracao { get; set; }

        [Required(ErrorMessage = "Obrigatório selecionar um perfil.")]
        [Display(Name = "Perfil")]
        public int PerfilUsuarioId { get; set; }
    }
}
