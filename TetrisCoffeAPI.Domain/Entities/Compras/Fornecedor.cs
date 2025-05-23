namespace TetrisCoffeAPI.Domain.Entities.Compras
{
    using TetrisCoffeAPI.Domain.Abstract;
    using TetrisCoffeAPI.Domain.Enums;

    public class Fornecedor : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public StatusVinculo Ativo { get; set; } = StatusVinculo.Ativo;

        // Construtor padrão
        public Fornecedor() { }
    }
}

// basicamente, a classe fornecedor é uma entidade que representa um fornecedor de produtos ou serviços. Ela herda de BaseEntity, o que significa que ela tem um Id, CreatedOn e ModifiedOn. A classe contém propriedades como Nome, CNPJ, Telefone, Email, Endereco e Ativo. O construtor padrão inicializa a classe com valores padrão.