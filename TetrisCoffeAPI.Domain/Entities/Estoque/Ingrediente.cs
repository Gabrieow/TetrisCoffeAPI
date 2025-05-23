namespace TetrisCoffeAPI.Domain.Entities.Estoque
{
    using TetrisCoffeAPI.Domain.Abstract;

    public class Ingrediente : BaseEntity
    {
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        // Quando quiser especificar o produto que usa o ingrediente
        public Guid? ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}

// basicamente, a classe Ingrediente representa um ingrediente utilizado na preparação de produtos. Ela herda de BaseEntity, o que significa que ela tem um Id, CreatedOn e ModifiedOn. A classe contém propriedades como Nome, Descricao, Preco e Quantidade. O construtor padrão inicializa a classe com valores padrão.