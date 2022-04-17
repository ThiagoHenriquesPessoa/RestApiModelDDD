namespace RestApiModelDDD.Domain.Entitys
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool IsDisponivel { get; set; }
    }
}
