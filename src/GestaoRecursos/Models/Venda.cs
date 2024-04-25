using Models;
namespace GestaoRecursos.Models;

public class Venda
{
    public int Id { get; set; }
    public List<Produto> Produtos { get; set; }
    public string NotaFiscal { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime? DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
}
