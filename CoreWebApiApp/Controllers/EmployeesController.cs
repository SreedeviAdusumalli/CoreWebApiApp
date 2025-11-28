using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApiApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
     
        [HttpGet]
        public string Get()
        {
            return "From Employee Controller GET method!";
        }

        [HttpGet]
        public string GetEmployee()
        {
            return "From Employee Controller GetEmployee method!";
        }
    }
}
