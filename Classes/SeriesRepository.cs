using System;
using System.Collections.Generic;
using DIO.Series.Interface;
 

namespace DIO.Series
{
    public class SeriesRepository : IRepository<Series>
    {
        private List<Series> seriesList = new List<Series>();
        
        public List<Series> Listing()
        {
            return seriesList;
        }
        
        public Series ReturnById(int id)
        {
            return seriesList[id];
        }

        public void Insert(Series entity)
        {
            seriesList.Add(entity);
        }
       
        public void Delete(int id)
        {
            seriesList[id].ToDelete();
        }
 
        public void Update(int id, Series entity)
        {
            seriesList[id] = entity;
        }

        public int NextId()
        {
            return seriesList.Count;
        }
         
    }
}