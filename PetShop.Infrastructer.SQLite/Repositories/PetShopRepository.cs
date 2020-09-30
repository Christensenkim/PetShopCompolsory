using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructer.SQLite.Data.Repositories
{
    public class PetShopRepository : IPetShopRepository
    {
        readonly PetShopContext _ctx;

        public PetShopRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }
        public Pet Create(Pet pet)
        {
            var newPet = _ctx.Pets.Add(pet).Entity;
            _ctx.SaveChanges();
            return newPet;
        }

        public Pet Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pet EditPet(Pet petEdit)
        {
            throw new NotImplementedException();
        }

        public List<Pet> FindPetsByType(string searchedType)
        {
            throw new NotImplementedException();
        }

        public List<Pet> GetListSortedByPrice()
        {
            throw new NotImplementedException();
        }

        public Pet GetPetByID(int id)
        {
            return _ctx.Pets.FirstOrDefault(c => c.PetId == id);
        }

        public IEnumerable<Pet> ReadPets(string petType)
        {
            return _ctx.Pets;
        }
    }
}
