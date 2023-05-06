using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.DTO;

namespace ApplicationApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly ITemplate _temp;
        private readonly OkrServices _services;
        public TemplateController(ITemplate temp, OkrServices services)
        {
            _temp = temp;
            _services = services;
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
        [HttpPost]
        public IActionResult CreateTemplate(TemplateDTO temp) 
        {
            return Ok(_services.CreateTemp(temp));
        }
    }
}
