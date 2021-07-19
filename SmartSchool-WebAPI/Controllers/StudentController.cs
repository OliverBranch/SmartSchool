using System;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){

            try
            {
            return Ok("Tudo Certo");
            }
            catch (Exception e)
            {
                return BadRequest($"Error: {e.Message}");
            }
        }
        
    }   
}