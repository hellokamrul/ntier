using DAL.Context;
using DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly ITemplate _temp;
        public TemplateController(ITemplate temp)
        {
            _temp = temp;
        }
        [HttpGet]
        public IActionResult MyWorks(int id)
        {
            return Ok(_temp.GetTodayTaskByUid(id));
        }
        [HttpGet]
        public IActionResult TempList(int id)
        {
            return Ok(_temp.GetTemplateList());
        }
    }
}
