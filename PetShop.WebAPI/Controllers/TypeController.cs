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
    public class TypeController : ControllerBase
    {
        private readonly ITypeService _TypeService;

        public TypeController(ITypeService typeService)
        {
            _TypeService = typeService;
        }

        // GET: api/<TypeController>
        [HttpGet]
        public IEnumerable<PetType> Get()
        {
            var types = _TypeService.GetTypes();

            return types;
        }

        // GET api/<TypeController>/5
        [HttpGet("{id}")]
        public PetType Get(int id)
        {
            return _TypeService.FindTypeByID(id);
        }

        // POST api/<TypeController>
        [HttpPost]
        public PetType Post([FromBody] PetType petType)
        {
            return _TypeService.CreateType(petType);
        }

        // PUT api/<TypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PetType petType)
        {
            _TypeService.UpdateType(id, petType);
        }

        // DELETE api/<TypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _TypeService.DeleteType(id);
        }
    }
}
