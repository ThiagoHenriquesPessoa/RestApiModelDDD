using Microsoft.EntityFrameworkCore;
using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModelDDD.Infrastruture.Data.Repositorys
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly SqlContext _sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Add(T obj)
        {
            try
            {
                _sqlContext.Add(obj);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _sqlContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _sqlContext.Set<T>().Find(id);
        }

        public void Remove(int id)
        {
            try
            {
                var obj = _sqlContext.Set<T>().Find(id);
                _sqlContext.Set<T>().Remove(obj);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(T obj)
        {
            try
            {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}