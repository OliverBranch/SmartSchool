using Microsoft.AspNetCore.Mvc;

namespace Name
{
    [ApiController]
    [Route("[api/controller]")]
    public class TeacherController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok("Israel Oliveira");
        }
    }   
}
