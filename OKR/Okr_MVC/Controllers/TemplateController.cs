using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
namespace Okr_MVC.Controllers
{
    public class TemplateController : Controller
    {
        private readonly HttpClient _httpClient;
        public TemplateController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Index()
        {
            //var response = _httpClient.GetAsync("https://localhost:7215/api/MyWorks");
            ////if(response.isSuccessStatus)
            //var data = await _httpClient
            return View();
        }
    }
}
