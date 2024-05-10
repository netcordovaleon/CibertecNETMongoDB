using APIMongoDB.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoRepository;
using SQLRepository;

namespace APIMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly PetServices _petServices;
        public PetController(PetServices petServices)
        {
            _petServices = petServices;
        }


        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get() {

            return Ok(await _petServices.GetAllAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(string id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Save(PetEntity pet)
        {
            await _petServices.SavePetAsync(pet);
            return Ok();
        }


        [HttpPut]
        [Route("")]
        public IActionResult Update(PetEntity pet)
        {
            return Ok();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok();
        }
    }
}
