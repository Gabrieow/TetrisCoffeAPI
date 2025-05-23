namespace TetrisCoffeAPI.Domain.Entities.Vendas
{
    using TetrisCoffeAPI.Domain.Abstract;
    using TetrisCoffeAPI.Domain.Enums;

    public class Pagamento : BaseEntity
    {
        public TipoPagamento TipoPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public StatusPagamento Status { get; set; } = StatusPagamento.Pendente;

        // Construtor padrão
        public Pagamento() { }
    }
}

// basicamente, a classe Pagamento é uma entidade que representa um pagamento. Ela herda de BaseEntity, o que significa que ela tem um Id, CreatedOn e ModifiedOn. A classe contém propriedades como TipoPagamento, Valor, DataPagamento e Confirmado. O construtor padrão inicializa a classe com valores padrão.