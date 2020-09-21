using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Core.ApplicationService;
using PetShop.Core.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetShop.WebAPI.Controllers
{
    


    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetShopService _petservice;

        public PetController(IPetShopService petShopService)
        {
            _petservice = petShopService;
        }

        /// <summary>
        /// gets the list of all the pets from the DB
        /// </summary>
        /// <returns></returns>
        // GET: api/<PetController>
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get([FromQuery] string type)
        {
            try
            {
                return _petservice.GetPets(type);
            }
            catch (Exception)
            {
                return StatusCode(500, "You broke it");
            }
        }

        /// <summary>
        /// get a specifik pet by Id from the DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<PetController>/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            try
            {
                Pet pet = _petservice.FindPetByID(id);

                if (pet != null)
                {
                    return pet;
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "You broke it");
            }
        }

        /// <summary>
        /// creates a new pet in the database
        /// </summary>
        /// <param name="pet"></param>
        // POST api/<PetController>
        [HttpPost]
        public ActionResult<Pet> Post([FromBody] Pet pet)
        {
            try
            {
                return _petservice.CreatePet(pet);
            }
            catch (Exception)
            {
                return StatusCode(500, "You Broke it");
            }
        }

        /// <summary>
        /// updates the pet in the DB with new info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pet"></param>
        // PUT api/<PetController>/5
        [HttpPut("{id}")]
        public ActionResult<Pet> Put(int id, [FromBody] Pet pet)
        {
            try
            {
                var pett = _petservice.UpdatePet(id, pet);

                if(pett == null)
                {
                    return NotFound();
                }
                else
                {
                    return pett;
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "You Broke it");
            }
        }

        /// <summary>
        /// deletes a Pet with the same ID
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<PetController>/5
        [HttpDelete("{id}")]
        public ActionResult<Pet> Delete(int id)
        {
            try
            {
                var pet = _petservice.DeletePet(id);

                if (pet == null)
                {
                    return NotFound();
                }
                else
                {
                    return pet;
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "You broke it");
            }
        }
    }
}
