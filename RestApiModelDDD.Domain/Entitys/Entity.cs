﻿using System;

namespace RestApiModelDDD.Domain.Entitys
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity()
        {
            Random novo = new Random();
            Id = novo.Next(4,5);
        }
    }
}
