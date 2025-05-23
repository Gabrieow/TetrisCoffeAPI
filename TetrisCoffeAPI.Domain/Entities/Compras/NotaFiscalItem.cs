namespace TetrisCoffeAPI.Domain.Entities.Compras
{
    using TetrisCoffeAPI.Domain.Abstract;
    using TetrisCoffeAPI.Domain.Enums;

    public class NotaFiscalItem : BaseEntity
    {
        public string Descricao { get; set; } = string.Empty;
        public decimal ValorUnitario { get; set; } = 0;
        public int Quantidade { get; set; } = 0;
        public decimal ValorTotal { get; set; } = 0;
        public UnidadeMedida UnidadeMedida { get; set; } = UnidadeMedida.Unidade;

        // Vinculação com NotaFiscal
        // uma nota fiscal pode ter muitos itens
        // e um item pertence a uma nota fiscal
        public Guid NotaFiscalId { get; set; }
        public required NotaFiscal NotaFiscal { get; set; }
    }
}

// basicamente, a classe NotaFiscalItem é uma representação de um item em uma nota fiscal e contém informações como descrição, valor unitário, quantidade, valor total e unidade de medida.