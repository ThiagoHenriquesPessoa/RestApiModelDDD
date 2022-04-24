namespace RestApiModelDDD.Application.Dtos
{
    public class ClienteDto : Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
    }
}