using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoRecursos.Models
{
    public class PerfilUsuario
    {
        [Required(ErrorMessage = "Obrigatório fornecer nome do perfil.")]
        [Display(Name = "Nome do perfil")]
        public string NomePerfil { get; set; }
        public int Id { get; set; }
        [Display(Name = "Permissão")]
        [Required(ErrorMessage = "Obrigatório selecionar uma área de permissão.")]
        public string RoleId { get; set; }

        [Required(ErrorMessage = "Obrigatório definir o campo de ativo.")]
        public bool Ativo { get; set; }

        [Display(Name = "Data de criação")]
        public DateTime? DataCriacao { get; set; }

        [Display(Name = "Data de alteração")]
        public DateTime? DataAlteracao { get; set; }
        public ICollection<Usuario>? Usuarios { get; set; }
    }

    public enum Perfil
    {
        Admin,
        Venda,
        Compra,
        Saida,
        Entrada,
        Producao
    }
}
