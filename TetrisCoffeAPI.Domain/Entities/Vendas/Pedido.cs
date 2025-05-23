namespace TetrisCoffeAPI.Domain.Entities.Vendas
{
    using TetrisCoffeAPI.Domain.Abstract;
    using TetrisCoffeAPI.Domain.Enums;

    public class Pedido : BaseEntity
    {
        public Guid ClienteId { get; set; }
        public Guid PagamentoId { get; set; }
        public Guid ProdutoId { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusPedido Status { get; set; } = StatusPedido.EmPreparacao;

        // Construtor padrão
        public Pedido() { }
    }
}

// basicamente, a classe Pedido é uma entidade que representa um pedido. Ela herda de BaseEntity, o que significa que ela tem um Id, CreatedOn e ModifiedOn. A classe contém propriedades como ClienteId, PagamentoId, ProdutoId, DataPedido, ValorTotal e Status. O construtor padrão inicializa a classe com valores padrão.