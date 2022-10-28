using Microsoft.AspNetCore.Mvc;
using Northwind_API.Models;
using System.Diagnostics;

namespace Northwind_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _clientFactory;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
         {
            HttpClient httpClient = _clientFactory.CreateClient(name: "Northwind_API");
 

     HttpRequestMessage request = new HttpRequestMessage(method: HttpMethod.Get, requestUri: "/api/Employé");

            HttpResponseMessage response = await httpClient.SendAsync(request);

            IList<EmployeModel> persons = await response.Content.ReadFromJsonAsync<IList<EmployeModel>>();

            return View(persons);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}