using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportQuestTracker.Contracts;

namespace SportQuestTracker.Controllers
{

    /// <summary>
    /// Endpoint used to authenticate login for users
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        // GET
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}