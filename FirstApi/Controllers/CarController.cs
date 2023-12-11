using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private Car _car;
        private IApiLogger _logger;
        private IAccessories _accessories;
        public CarController(Car c,IApiLogger logger, IAccessories s)
        {
            _car = c;
            _logger = logger;
            _logger.Log("CarController instance is created");
            _accessories = s;

        }
        [HttpGet("/drive")]
        public IActionResult Drive()
        {
            _logger.Log("Driving() api called successfully!");
            return Ok("Driving at 100kmph");
        }
    }
}
