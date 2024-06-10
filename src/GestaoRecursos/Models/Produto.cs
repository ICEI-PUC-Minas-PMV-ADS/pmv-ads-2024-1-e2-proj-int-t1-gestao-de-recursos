using GestaoRecursos.Models;

namespace Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int TipoProdutoId { get; set; }
    public virtual TipoProduto TipoProduto { get; set; }
    public bool Ativo { get; set; }
    public DateTime? DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    public virtual List<Venda> Vendas { get; set; }
    public virtual List<Compra> Compras { get; set; }
    public virtual List<ListaTecnica> ListasTecnicas { get; set; }

}