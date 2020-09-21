using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;

namespace PetShop.Infrastructure.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        private FakeDB _fakeDB = new FakeDB();

        public Owner Create(Owner owner)
        {
            throw new NotImplementedException();
        }

        public Owner Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Owner EditOwner(Owner ownerEdit)
        {
            throw new NotImplementedException();
        }

        public Owner GetOwnerByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Owner> ReadOwners()
        {
            throw new NotImplementedException();
        }
    }
}
