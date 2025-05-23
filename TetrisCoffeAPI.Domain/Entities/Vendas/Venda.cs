namespace TetrisCoffeAPI.Domain.Entities.Vendas
{
    using TetrisCoffeAPI.Domain.Abstract;
    using TetrisCoffeAPI.Domain.Enums;

    public class Venda : BaseEntity
    {
        public Guid ClienteId { get; set; }
        public Guid PagamentoId { get; set; }
        public Guid ProdutoId { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusVenda Status { get; set; } = StatusVenda.Pendente;

        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        // Construtor padrão
        public Venda() { }
    }
}

// basicamente, a classe Venda é uma entidade que representa uma venda. Ela herda de BaseEntity, o que significa que ela tem um Id, CreatedOn e ModifiedOn. A classe contém propriedades como ClienteId, PagamentoId, ProdutoId, DataVenda, ValorTotal e Status. Ela também possui uma lista de Pedidos associados à venda. O construtor padrão inicializa a classe com valores padrão.