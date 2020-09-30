using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructer.SQLite.Data.Repositories
{
    class OwnerRepository : IOwnerRepository
    {
        readonly PetShopContext _ctx;

        public OwnerRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }
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
