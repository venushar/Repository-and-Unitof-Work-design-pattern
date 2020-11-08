using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common.Interfaces;
using WebApi.Common.Models;

namespace WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private IUserBusiness _userBusiness;
        public UserController(IUserBusiness userBusiness)
        {
            this._userBusiness = userBusiness;
        }



        [HttpPost("api/add")]
        public async Task<IActionResult> AddUser([FromBody] UserModel model)
        {

            return StatusCode(StatusCodes.Status500InternalServerError,"internal server error from api");


           /* try
            {
                await _userBusiness.Post(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }*/

        }


        [HttpGet("allUsers")]
        public async Task<IEnumerable<UserModel>> GetAll()
        {
            return await _userBusiness.GetAll();


        }

        [HttpGet("getUser")]
        public async Task<UserModel> Get(int userId)
        {
            return await _userBusiness.Get(userId);


        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UserModel user)
        {
            await _userBusiness.Put(user);
            return Ok();


        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {

                await _userBusiness.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }


        }


    }
}
