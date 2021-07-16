using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DioSeries.Class;

namespace DioSeries.Interface
{
    public interface IRepository<T>
    {
         List <T> GetAll();
         T ReturnById(int id);
         void Create(T entity);
         void Update(int id, T entity);
         void Delete(int id);
         int NextId();
    }
}