using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Web.Api.Data.Repositories
{
    interface IRepository<T> where T:class
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(Guid Id);
        void SaveChanges();
        T  Get(Guid Id);
        IEnumerable<T>  GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> Predicate);

    }
}
