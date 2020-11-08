using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Common.Models
{
   public  class OrderModel
    {

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}
