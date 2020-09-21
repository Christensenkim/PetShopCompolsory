using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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
        public ActionResult<IEnumerable<PetType>> Get()
        {
            try
            {
                return _TypeService.GetTypes();
            }
            catch (Exception)
            {
                return StatusCode(500, "You broke it");
            }
        }

        // GET api/<TypeController>/5
        [HttpGet("{id}")]
        public ActionResult<PetType> Get(int id)
        {
            try
            {
                var petType = _TypeService.FindTypeByID(id);

                if (petType != null)
                {
                    return petType;
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

        // POST api/<TypeController>
        [HttpPost]
        public ActionResult<PetType> Post([FromBody] PetType petType)
        {
            try
            {
                return _TypeService.CreateType(petType);
            }
            catch (Exception)
            {
                return StatusCode(500, "You Broke it");
            }
        }

        // PUT api/<TypeController>/5
        [HttpPut("{id}")]
        public ActionResult<PetType> Put(int id, [FromBody] PetType petType)
        {
            try
            {
                var petType1 = _TypeService.UpdateType(id, petType);

                if (petType1 == null)
                {
                    return NotFound();
                }
                else
                {
                    return petType1;
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "You Broke it");
            }
            
        }

        // DELETE api/<TypeController>/5
        [HttpDelete("{id}")]
        public ActionResult<PetType> Delete(int id)
        {
            try
            {
                var petType = _TypeService.DeleteType(id);

                if (petType == null)
                {
                    return NotFound();
                }
                else
                {
                    return petType;
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "You broke it");
            }
            
        }
    }
}
