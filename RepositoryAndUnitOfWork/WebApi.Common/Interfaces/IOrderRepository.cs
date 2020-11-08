using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Common.Models;

namespace WebApi.Common.Interfaces
{
   public  interface IOrderRepository//:IAsyncRepository<OrderModel>
    {
       // Task<IEnumerable<OrderModel>> FindAsync(Expression<Func<OrderModel, bool>> expression);
    }
}
