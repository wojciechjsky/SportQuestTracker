using Microsoft.AspNetCore.Mvc;

namespace SportQuestTracker.Controllers
{
    public class CompanyController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}