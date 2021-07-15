using Microsoft.AspNetCore.Mvc;

namespace Name
{
    [ApiController]
    [Route("[api/controller]")]
    public class StudentController: ControllerBase
    {
         [HttpGet]
        public IActionResult Get(){
            return Ok("TestAluno");
        }
        
    }   
}