namespace TetrisCoffeAPI.Domain.Abstract
{
    public abstract class BaseEntity
    {
        // 3 atributos
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        // Construtor encapsulado
        protected BaseEntity() { }
    }
}