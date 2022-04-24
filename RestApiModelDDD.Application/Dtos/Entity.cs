using System;

namespace RestApiModelDDD.Application.Dtos
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity()
        {
            Random id = new Random();
            Id = id.Next(5);
        }
    }
}
