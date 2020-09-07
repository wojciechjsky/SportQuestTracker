using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportQuestTracker.Models;

namespace SportQuestTracker.Controllers
{
    public class TestController : Controller
    {
        //[Route("api/[controller]")]
        //[ApiController]

        //public class HomeController : ControllerBase
        //{
        //    public IActionResult Index()
        //    {
        //        return Ok("Hello World!");
        //    }
        //}
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
