using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entities;
using System.Linq;
using WebApi.Common.Interfaces;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WebApi.Common.Models;

namespace WebApi.Data.Repository
{
  public class OrderRepository:EFRepository<Order> , IOrderRepository
    {
        private readonly WebApiDbContext _WebApiDbContext;
        public OrderRepository(WebApiDbContext context) : base(context)
        {
            this._WebApiDbContext = context;
        }

       
        public async Task<IEnumerable<Order>> FindAsync(Expression<Func<Order, bool>> expression)
        {
            return await _WebApiDbContext.Set<Order>().Where(expression).ToListAsync().ConfigureAwait(false);
        }

      
    }
}
