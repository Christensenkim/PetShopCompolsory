using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;

namespace PetShop.Infrastructure.Data
{
    public class PetTypeRepository : IPetTypeRepository
    {
        private FakeDB _fakeDB = new FakeDB();

        public PetType Create(PetType petType)
        {
            throw new NotImplementedException();
        }

        public PetType Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PetType EditPetType(PetType ownerEdit)
        {
            throw new NotImplementedException();
        }

        public PetType GetPetTypeByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<PetType> ReadTypes()
        {
            throw new NotImplementedException();
        }
    }
}
