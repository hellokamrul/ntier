using DAL.Interfaces;
using DAL.Repository;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using DAL.DTO;

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

    //[HttpPost]
    //public IActionResult CreateTemplate(Template temp)
    //{
    //    temp.Id = 1;
    //    temp.Name = "xyz";
    //    temp.OwnerId = 1;
    //    return Ok(_temp.CreateTemplate(temp));
    //}

    [HttpPost]
    public IActionResult CreateTemplate(TemplateDTO grp)
    {
       var data = _temp.CreateTemplate(grp);
        return Ok(data);
    }

    [HttpPost]
    public IActionResult CreateTask(TasksDTO task)
    {
        try
        {
            var result = _temp.CreateTask(task);
            return Ok(result);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while creating the task.");
        }
    }

    [HttpDelete]
    public IActionResult DeleteTask(int id)
    {
        return Ok(_temp.DeleteTask(id));
    }

    [HttpPut]
    public IActionResult EditTask(TasksDTO tasks)
    {
        return Ok(_temp.UpdateTask(tasks)); 
    }
}

