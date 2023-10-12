namespace ApiCatalago.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("Produtos")]
public class Produto
{
    //Classes que  possuem somente propiedades são chamadas de anemicas

    //Chave Primaria para o EF
    [Key]
    public int ProdutoId { get; set; }
    //
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? Descricao { get; set; }

    [Required]
    [Column(TypeName ="Decimal (10,2)")]

    public decimal Preco { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }

    public DateTime DataCadastro { get; set; }


    // cada produto possui uma categoria e uma categoria ID
    public int CategoriaId { get; set; }

    public Categoria? Categoria { get; set; }

}
