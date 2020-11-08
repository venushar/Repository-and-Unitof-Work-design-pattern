using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
