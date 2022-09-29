using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class WelcomeController : Controller
    {
        [HttpGet]
        public ActionResult<string> Index() => $"Welcome to FD Manager. {DateTime.UtcNow}";        
    }
}
