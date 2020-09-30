using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructer.SQLite.Data.Repositories
{
    class PetShopRepository : IPetShopRepository
    {
        readonly PetShopContext _ctx;

        public PetShopRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }
        public Pet Create(Pet pet)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Pet> ReadPets(string petType)
        {
            throw new NotImplementedException();
        }
    }
}
