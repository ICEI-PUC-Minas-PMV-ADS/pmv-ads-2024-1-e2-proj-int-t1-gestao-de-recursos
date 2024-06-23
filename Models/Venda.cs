namespace Models;

public class Venda
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
    public string NotaFiscal { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime? DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    public int Quantidade { get; set; }
}
