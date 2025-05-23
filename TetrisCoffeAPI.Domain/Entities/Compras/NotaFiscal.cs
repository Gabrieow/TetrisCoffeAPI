namespace TetrisCoffeAPI.Domain.Entities.Compras
{
    using TetrisCoffeAPI.Domain.Abstract;

    public class NotaFiscal : BaseEntity
    {
        public string NumeroNota { get; set; } = string.Empty;
        public DateTime DataEmissao { get; set; } = DateTime.UtcNow;
        public string ChaveAcesso { get; set; } = string.Empty;
        public string NomeArquivo { get; set; } = string.Empty;
        public string TipoNota { get; set; } = string.Empty;
        public string CNPJEmitente { get; set; } = string.Empty;
        public string NomeEmitente { get; set; } = string.Empty;
        public string CNPJDestinatario { get; set; } = string.Empty;
        public string NomeDestinatario { get; set; } = string.Empty;

        // Criando vinculação com NotaFiscalItem
        public List<NotaFiscalItem> Itens { get; set; } = new List<NotaFiscalItem>();
    }
}

// basicamente, a classe herda de BaseEntity, o que significa que ela tem um Id, CreatedOn e ModifiedOn. A classe também contém uma lista de itens (NotaFiscalItem) que estão vinculados a essa nota fiscal. Isso permite que você tenha uma lista de produtos ou serviços associados a cada nota fiscal.