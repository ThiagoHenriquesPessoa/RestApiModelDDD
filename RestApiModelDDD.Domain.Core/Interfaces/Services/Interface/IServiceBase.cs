using System.Collections.Generic;

namespace RestApiModelDDD.Domain.Core.Interfaces.Services.Interface
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(T obj);

        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}