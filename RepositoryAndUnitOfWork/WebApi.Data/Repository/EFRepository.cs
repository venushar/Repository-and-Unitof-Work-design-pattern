
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Common.Interfaces;

namespace WebApi.Data.Repository
{
    public class EFRepository<T> : IAsyncRepository<T> where T : class
    {
        private readonly  WebApiDbContext context;

        public EFRepository(WebApiDbContext apiContext)
        {
            context = apiContext;
        }

        public async Task Add(T entity)
        {
            await context.Set<T>().AddAsync(entity).ConfigureAwait(false);
            await context.SaveChangesAsync().ConfigureAwait(false);

           
        }

        public async Task Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).ToListAsync().ConfigureAwait(false);
        }

        public async Task<T> SingleOrDefaultAsync
       (Expression<Func<T, bool>> expression) 
        {
            return await context.Set<T>().SingleOrDefaultAsync(expression).ConfigureAwait(false);
        }
        public async Task<T> Get(int id)
        {
            return await context.Set<T>().FindAsync(id).ConfigureAwait(false);
        }

        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync().ConfigureAwait(false);
        }

        public async Task<T> Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync().ConfigureAwait(false);
            return entity;
        }

    }
}
