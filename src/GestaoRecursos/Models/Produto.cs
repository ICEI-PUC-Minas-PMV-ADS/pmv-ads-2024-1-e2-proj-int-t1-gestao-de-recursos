namespace Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int TipoProdutoId { get; set; }
    public TipoProduto TipoProduto { get; set; }
    public bool Ativo { get; set; }
    public DateTime? DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    public List<Venda> Vendas { get; set; }
    public List<Compra> Compras { get; set; }

}