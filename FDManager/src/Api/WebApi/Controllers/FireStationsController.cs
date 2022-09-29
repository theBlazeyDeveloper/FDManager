using Data.FireStationAggregate;
using Microsoft.AspNetCore.Mvc;
using Shared.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/{controller}/{action}")]
    public class FireStationsController : Controller
    {
        readonly IRepository<FireStation> _repo;

        public FireStationsController(IRepository<FireStation> _repo) : base()
        {
            this._repo = _repo;
        }

        [HttpGet]
        public async IAsyncEnumerable<FireStationDTO> Get()
        {
            await foreach (var station in _repo.GetAsync(null))
                yield return (FireStationDTO)station;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FireStation[] data) 
        {
            if (data != null)
            {
                try
                {
                    var result = await _repo.SaveMany(data);

                    return Created("/api/firestations/get", data);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else
                return NoContent();                       
        }        
    }
}
