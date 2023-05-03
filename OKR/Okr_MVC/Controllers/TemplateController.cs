using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
namespace Okr_MVC.Controllers
{
    public class TemplateController : Controller
    {
        
        private readonly HttpClient _client;
        public TemplateController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7215/api");
        }
        public IActionResult Index()
        {
            return View();
        }
            public IActionResult TaskList(int id)
        {
            List<UserTaskAssign> taskList = new List<UserTaskAssign>();
            var response = _client.GetAsync(_client.BaseAddress+ "/Template/MyWorks/"+id).Result;
            if(response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                taskList = JsonConvert.DeserializeObject<List<UserTaskAssign>>(data);
            }
            return View(taskList);
        }
        public IActionResult TempList()
        {
            List<Template> taskList = new List<Template>();
            var response = _client.GetAsync(_client.BaseAddress + "/Template/TempList").Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                taskList = JsonConvert.DeserializeObject<List<Template>>(data);
            }
            return View(taskList);
        }
    }
}
