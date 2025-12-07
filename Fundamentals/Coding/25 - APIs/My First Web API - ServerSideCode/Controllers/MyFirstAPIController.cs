using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI_ServerSideCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstAPIController : ControllerBase
    {

        [HttpGet("GetMyName", Name = "MyName")]
        public String GetMyName()
        {
            return "My name is Mohamed Morad";
        }

        [HttpGet("GetYourName", Name = "YourName")]
        public String GetYourName()
        {
            return "Your Name is Ali Basha";
        }


        [HttpGet("TwoNumsSumFunc")]
        public int Sum2Numbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
