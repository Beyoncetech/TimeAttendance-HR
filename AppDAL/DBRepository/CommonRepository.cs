﻿using AppDAL.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDAL.DBRepository
{
    public interface ICommonRepository<T> where T : class
    {
        IEnumerable<T> GetAll();        
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    public class CommonRepository<T> : ICommonRepository<T> where T : class
    {
        private readonly AppDBContext _DBContext;        
        private DbSet<T> entities;
        private string errorMessage = string.Empty;
        public CommonRepository(AppDBContext DBContext)
        {
            _DBContext = DBContext;
            entities = _DBContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }        
        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Add(entity);
            _DBContext.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Attach(entity);
            _DBContext.Entry(entity).State = EntityState.Modified;
            _DBContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
                       
            entities.Remove(entity);
            _DBContext.Entry(entity).State = EntityState.Deleted;
            _DBContext.SaveChanges();
        }
    }
   
}
