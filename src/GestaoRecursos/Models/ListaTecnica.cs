using Microsoft.EntityFrameworkCore;
using Models;
using System.ComponentModel.DataAnnotations;

namespace GestaoRecursos.Models
{
    public class ListaTecnica
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório fornecer o produto.")]
        public int ProdutoId { get; set; }

        public virtual Produto? Produto { get; set; }

        [Display(Name = "Matéria Prima")]
        [Required(ErrorMessage = "Obrigatório fornecer uma matéria prima.")]
        public int MateriaPrimaId { get; set; }

        public virtual Produto? MateriaPrima { get; set; }

        [Display(Name = "Quantidade (KG)")]
        public required float Quantidade { get; set; }

        public bool Ativo { get; set; } = true;

        [Display(Name = "Data de criação")]
        public DateTime? DataCriacao { get; set; }

        [Display(Name = "Data de alteração")]
        public DateTime? DataAlteracao { get; set; }
    }
}