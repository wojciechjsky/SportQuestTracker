using Microsoft.AspNetCore.Mvc;

namespace SportQuestTracker.Controllers
{
    public class UserController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}