using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Common.Models;

namespace WebApi.Common.Interfaces
{
    interface IOrderBusiness
    {

        Task<List<OrderModel>> GetAll();
    }
}
