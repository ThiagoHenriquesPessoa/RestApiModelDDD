namespace RestApiModelDDD.Application.Dtos
{
    public class ProdutoDto: Entity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}