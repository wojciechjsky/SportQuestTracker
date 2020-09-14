using Microsoft.AspNetCore.Mvc;

namespace SportQuestTracker.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}