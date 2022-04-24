﻿using System.Collections.Generic;

namespace RestApiModelDDD.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(int id);

        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}