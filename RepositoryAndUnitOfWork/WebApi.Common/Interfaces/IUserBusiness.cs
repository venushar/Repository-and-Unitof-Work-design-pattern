using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Common.Models;

namespace WebApi.Common.Interfaces
{
  public interface IUserBusiness
    {
        Task<List<UserModel>> GetAll();
        Task Put(UserModel user);
        Task<UserModel> Get(int id);        
        Task Post(UserModel user);
        Task Delete(int id);

    }
}
