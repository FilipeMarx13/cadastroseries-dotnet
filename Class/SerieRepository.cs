using System.Linq;
using System.Collections.Generic;
using System;
using DioSeries.Interface;
using System.Threading.Tasks;

namespace DioSeries.Class
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> serieList = new List<Serie>();

        public void Create(Serie entity)
        {
            serieList.Add(entity);
        }

        public void Delete(int id)
        {
            serieList.RemoveAt(id);
        }

        public List<Serie> GetAll()
        {
            return serieList;
        }

        public int NextId()
        {
            return serieList.Count;
        }

        public Serie ReturnById(int id)
        {
            return serieList[id];
        }

        public void Update(int id, Serie entity)
        {
            serieList[id] = entity;
        }
    }
}