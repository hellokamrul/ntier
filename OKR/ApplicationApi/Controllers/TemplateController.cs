using BLL.DTOs;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

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
    public IActionResult CreateTemplate(Template temp)
    {
        temp.Id = 1;
        temp.Name = "xyz";
        temp.OwnerId = 1;
        return Ok(_temp.CreateTemplate(temp));
    }

    [HttpPost]
    public IActionResult Add(TemplateDTO grp)
    {
        var data = _services.Add(grp);
        return Ok(data);
    }
}
