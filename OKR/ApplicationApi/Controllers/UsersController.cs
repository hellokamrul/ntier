using BLL.DTO;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApplicationApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private UserServices _services;
        //[HttpPost]      
        //public HttpResponseMessage Add([FromBody] UserDTO user)
        //{
        //    var data = UserServices.Add(grp);
        //    return Request.CreateResponse(HttpStatusCode.OK, data);
        //}
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDTO user)
        {
            var data = UserServices.Add(user);
            return Ok(data);
        }

    }
}
