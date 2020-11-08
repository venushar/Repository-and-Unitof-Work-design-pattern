using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Common.Models;

namespace WebApi.Common.Interfaces

{
    public interface IAsyncRepository<T> where T : class
    {

        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
        Task<T> SingleOrDefaultAsync (Expression<Func<T, bool>> expression);

    }
}

