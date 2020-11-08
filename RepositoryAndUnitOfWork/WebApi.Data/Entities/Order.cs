using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entities
{
  public  class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }


    }
}
