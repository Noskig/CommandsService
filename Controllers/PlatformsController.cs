using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }
    [HttpPost]
        public ActionResult Test(){
            Console.WriteLine("---> Inbound POST # Command Service");

            return Ok("---> Hit /c/Api");
        }
    }
}