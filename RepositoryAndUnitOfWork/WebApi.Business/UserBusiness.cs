using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common.Interfaces;
using WebApi.Common.Models;
using WebApi.Data.Entities;
using WebApi.Data.Repository;

namespace WebApi.Business
{
    public class UserBusiness:IUserBusiness
    {

        private readonly IAsyncRepository<User> _repository;

        public UserBusiness(IAsyncRepository<User> repository)
        {
            this._repository = repository;
        }


        public async Task<List<UserModel>> GetAll()
        {
           var result= await _repository.GetAll().ConfigureAwait(false);
            return result.Select(x => new UserModel { UserId = x.UserId, UserName = x.UserName }).ToList();
        
        }


        public async Task<UserModel> Get(int id)
        {
            var result= await _repository.Get(id).ConfigureAwait(false);
            return new UserModel
            {
                UserId = result.UserId,
                UserName = result.UserName
            };
        }


        public async Task Put(UserModel user)
        {           
            
            await this._repository.Update(new User() {
            UserId= user.UserId,
            UserName=user.UserName,
            Orders=null
            }).ConfigureAwait(false);
        }

 
        public async Task Post(UserModel user)
        {
             await this._repository.Add(new User()
            {
                UserId = user.UserId,
                UserName = user.UserName
              
            }).ConfigureAwait(false);
        }

         public async Task  Delete(int id)
        {
            await this._repository.Delete(new User()
            {
                UserId = id               
            }).ConfigureAwait(false);
        }

    }
}
