namespace TetrisCoffeAPI.Domain.Entities.Compras
{
    using TetrisCoffeAPI.Domain.Abstract;
    using TetrisCoffeAPI.Domain.Enums;

    public class OrdemDeCompra : BaseEntity
    {
        public string NumeroOrdem { get; set; } = string.Empty;
        public DateTime DataEmissao { get; set; } = DateTime.UtcNow;
        public StatusOrdemDeCompra Status { get; set; } = StatusOrdemDeCompra.Pendente;
        public decimal ValorTotal { get; set; } = 0;

        // Vinculação com Fornecedor
        public Guid FornecedorId { get; set; }
        public required Fornecedor Fornecedor { get; set; }

        // Vinculação com NotaFiscal
        public List<NotaFiscal> NotasFiscais { get; set; } = new List<NotaFiscal>();

        // Vinculação com OrdemDeCompraItem
        public List<OrdemDeCompraItem> Itens { get; set; } = new List<OrdemDeCompraItem>();
    }
}

// basicamente, a classe OrdemDeCompra representa uma ordem de compra e contém informações como número da ordem, data de emissão, status, valor total, fornecedor associado e uma lista de itens da ordem de compra. Ela também possui um relacionamento com a classe Fornecedor e com a classe NotaFiscal.