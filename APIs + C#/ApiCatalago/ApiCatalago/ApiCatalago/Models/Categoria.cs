using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiCatalago.Models;
[Table("Categorias")]
public class Categoria
{
    //Classes que  possuem somente propiedades são chamadas de anemicas
    // Identificador da entidade para o EF. Sera a Chave Primaria
    [Key]
    public int CategoriaId { get; set; }
    //
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    //propiedade de navegação responsavel por unir as tabelas Categoria e Produtos no EF
    public ICollection<Produto>? Produtos { get; set; }

    public Categoria()
    {
        // inicializando a propiedade Produtos ( semelhante ao que fazemos com List e Queues)
        Produtos = new Collection<Produto>();
    }

}
