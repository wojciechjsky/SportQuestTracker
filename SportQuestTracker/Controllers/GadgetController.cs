using Microsoft.AspNetCore.Mvc;

namespace SportQuestTracker.Controllers
{
    public class GadgetController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}