using System;

namespace RestApiModelDDD.Domain.Entitys
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsActivo { get; set; }
    }
}
