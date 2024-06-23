using Models;
using System.ComponentModel.DataAnnotations;

namespace GestaoRecursos.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório fornecer nome.")]
        public string Nome { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int? Telefone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Obrigatório definir o campo de ativo.")]
        public bool Ativo { get; set; }

        [Display(Name = "Data de criação")]
        public DateTime? DataCriacao { get; set; }

        [Display(Name = "Data de alteração")]
        public DateTime? DataAlteracao { get; set; }
        public ICollection<Compra>? Compras { get; set; }
    }
}