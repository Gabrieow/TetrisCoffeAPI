namespace TetrisCoffeAPI.Domain.Entities.Estoque
{
    using TetrisCoffeAPI.Domain.Abstract;
    using TetrisCoffeAPI.Domain.Enums;

    public class Produto : BaseEntity
    {
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required UnidadeMedida UnidadeMedida { get; set; }
        public required CategoriaProduto Categoria { get; set; }
        public required decimal Preco { get; set; }
        public int Quantidade { get; set; }

        // Quando quiser especificar o ingrediente que o produto usa
        public ICollection<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();
    }
}

// basicamente, a classe Produto representa um produto que pode ser vendido. Ela herda de BaseEntity, o que significa que ela tem um Id, CreatedOn e ModifiedOn. A classe contém propriedades como Nome, Descricao, UnidadeMedida, Categoria, Preco e Quantidade. O construtor padrão inicializa a classe com valores padrão.