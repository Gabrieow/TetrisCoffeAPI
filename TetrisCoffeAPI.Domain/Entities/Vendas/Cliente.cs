namespace TetrisCoffeAPI.Domain.Entities.Vendas
{
    using TetrisCoffeAPI.Domain.Abstract;
    using TetrisCoffeAPI.Domain.Enums;

    public class Cliente : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public StatusVinculo Ativo { get; set; } = StatusVinculo.Ativo;

        // Construtor padrão
        public Cliente() { }
    }
}

// basicamente, a classe cliente é uma entidade que representa um cliente. Ela herda de BaseEntity, o que significa que ela tem um Id, CreatedOn e ModifiedOn. A classe contém propriedades como Nome, CPF, Telefone, Email, Endereco e Ativo. O construtor padrão inicializa a classe com valores padrão.