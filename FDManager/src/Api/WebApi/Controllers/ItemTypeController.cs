using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{    
    [ApiController]
    [Route("api/{controller}/{action}")]
    public class ItemTypeController : ControllerBase
    {
        public ItemTypeController()
        {
        }
    }
}
