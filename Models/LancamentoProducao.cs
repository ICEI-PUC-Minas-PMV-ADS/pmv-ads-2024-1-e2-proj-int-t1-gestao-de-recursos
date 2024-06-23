using System.ComponentModel.DataAnnotations;

namespace GestaoRecursos.Models
{
    public class LancamentoProducao
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lista tecnica é obrigatória")]
        [Display(Name = "Lista tecnica")]
        public required int ListaTecnicaId { get; set; }
        public virtual ListaTecnica? ListaTecnica { get ; set; }
        [Display(Name = "Quantidade (KG)")]
        public float Quantidade { get; set; }
    }
}
