using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Web.Api.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Web.Api.Data.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext context;

        public virtual GenericRepository(DbContext context)
        {
            this.context = context;
        }
        public virtual T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        public virtual void Delete(Guid Id)
        {
            context.Remove(Id);
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> Predicate)
        {
            return context.Set<T>().AsQueryable().Where(Predicate).AsEnumerable(); //ToList()
        }

        public virtual T Get(Guid Id)
        {
            return context.Find<T>(Id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsEnumerable(); //ToList()
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return context.Update(entity).Entity;
        }
    }
}
