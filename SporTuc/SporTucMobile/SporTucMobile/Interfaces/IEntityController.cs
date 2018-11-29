using SporTucMobile.Models.Base;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SporTucMobile.Interfaces
{
    public interface IEntityController<T> where T : EntityBase, new()
    {
        Task<List<T>> Get();

        Task<T> Get(int id);

        Task<ObservableCollection<T>> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null);

        Task<T> Get(Expression<Func<T, bool>> predicate);

        AsyncTableQuery<T> AsQueryable();

        Task<int> Insert(T entity);

        Task<int> Update(T entity);

        Task<int> Delete(T entity);

        Task<int> Count(Expression<Func<T, bool>> predicate = null);
    }
}
