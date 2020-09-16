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
        public IEnumerable<Pet> Get()
        {
            return _petservice.GetPets();
        }

        /// <summary>
        /// get a specifik pet by Id from the DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<PetController>/5
        [HttpGet("{id}")]
        public Pet Get(int id)
        {
            return _petservice.FindPetByID(id);
        }

        /// <summary>
        /// creates a new pet in the database
        /// </summary>
        /// <param name="pet"></param>
        // POST api/<PetController>
        [HttpPost]
        public void Post([FromBody] Pet pet)
        {
            _petservice.CreatePet(pet);
        }

        /// <summary>
        /// updates the pet in the DB with new info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pet"></param>
        // PUT api/<PetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pet pet)
        {
            _petservice.UpdatePet(pet);
        }

        /// <summary>
        /// deletes a Pet with the same ID
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<PetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _petservice.DeletePet(id);
        }
    }
}
