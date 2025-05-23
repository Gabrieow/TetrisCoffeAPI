namespace TetrisCoffeAPI.Domain.Entities.Compras
{
    using TetrisCoffeAPI.Domain.Abstract;

    public class OrdemDeCompraItem : BaseEntity
    {
        public string Descricao { get; set; } = string.Empty;
        public decimal ValorUnitario { get; set; } = 0;
        public int Quantidade { get; set; } = 0;
        public decimal ValorTotal { get; set; } = 0;
        public string UnidadeMedida { get; set; } = string.Empty;

        // uma ordem de compra pode ter muitos itens
        // e um item pertence a uma ordem de compra
        public Guid OrdemDeCompraId { get; set; }
        public required OrdemDeCompra OrdemDeCompra { get; set; }
    }
}

// basicamente, a classe OrdemDeCompraItem é uma representação de um item em uma ordem de compra e contém informações como descrição, valor unitário, quantidade, valor total e unidade de medida. Ela também possui um relacionamento com a classe OrdemDeCompra, indicando que um item pertence a uma ordem de compra específica.