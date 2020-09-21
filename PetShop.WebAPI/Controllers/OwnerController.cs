using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Core.ApplicationService;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        // GET: api/<OwnerController>
        [HttpGet]
        public ActionResult<IEnumerable<Owner>> Get()
        {
            try
            {
                return _ownerService.GetOwners();
            }
            catch (Exception)
            {
                return StatusCode(500, "You broke it");
            }
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            try
            {
                var owner = _ownerService.FindOwnerByID(id);

                if (owner != null)
                {
                    return owner;
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

        // POST api/<OwnerController>
        [HttpPost]
        public ActionResult<Owner> Post([FromBody] Owner owner)
        {
            try
            {
                return _ownerService.CreateOwner(owner);
            }
            catch (Exception)
            {
                return StatusCode(500, "You Broke it");
            }
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public ActionResult<Owner> Put(int id, [FromBody] Owner owner)
        {
            try
            {
                var owner1 = _ownerService.UpdateOwner(id, owner);

                if (owner1 == null)
                {
                    return NotFound();
                }
                else
                {
                    return owner1;
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "You Broke it");
            }
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult<Owner> Delete(int id)
        {
            try
            {
                var owner = _ownerService.DeleteOwner(id);

                if (owner == null)
                {
                    return NotFound();
                }
                else
                {
                    return owner;
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "You broke it");
            }
        }
    }
}
