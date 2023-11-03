﻿using Microsoft.EntityFrameworkCore;
using SomosAlkemy.DataAccess;
using SomosAlkemy.Repository.Interfaces;

namespace SomosAlkemy.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly ContextDB _contextDB;
        public Repository(ContextDB contextDB)
        {
            _contextDB = contextDB;
        }

        public async Task<List<T>> GetAll()
        {
            var entity = await _contextDB.Set<T>().ToListAsync();
            return entity;
        }
    }
}
