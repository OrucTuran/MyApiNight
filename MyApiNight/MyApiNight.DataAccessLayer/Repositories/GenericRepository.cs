﻿using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccessLayer.Repositories
{
    internal class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly ApiContext _context;

        public GenericRepository(ApiContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetBeyID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            var value=_context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var value = _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
