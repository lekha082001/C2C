using FirstApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FirstApi.Models;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IApiLogger _logger;
        public PersonController(IApiLogger logger)
        {
            _logger = logger;
        }
        private object updatedPerson;

        [HttpGet("/Api/people")]
        public IActionResult GetPeople()
        {
            _logger.Log("Start Logging GetPeople()!");
            _logger.Log("GetPeople() api call successfully!");
            return Ok(PersonOperations.GetPeople());
        }



        [HttpPost("/Api/create")]
        public IActionResult CreatePerson([FromBody]Person p)
        {
            PersonOperations.CreateNew(p);
            _logger.Log("CreatePerson() api call successfully!");
            return Created($"Created Person with aadhar {p.Aadhar}successfully", p);
        }
        [HttpPut("/Api/update/{pAadhar}")]
        public IActionResult UpdatePerson([FromRoute]string pAadhar, [FromBody] PersonController updatedPerson)
        {
            try
            {

                PersonOperations.Update(pAadhar, updatedPerson);
                _logger.Log("UpdatePerson() api call successfully!");
                return Ok("Update successfully");
            }
            catch (Exception ex)
            {
                _logger.Log("UpdatePerson() api call successfully!");
                return NotFound(ex.Message);
            }
        }
        [HttpDelete("/Api/delete")]
        public IActionResult DeletePerson([FromQuery] string pAadhar)
        {

            try
            {


                PersonOperations.Delete(pAadhar);
                _logger.Log("DeletePerson() api call successfully!");
                return Ok("Delete successfully");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                return NotFound(ex.Message);
            }

        }
    }
}