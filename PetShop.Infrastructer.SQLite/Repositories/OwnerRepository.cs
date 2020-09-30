using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructer.SQLite.Data.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        readonly PetShopContext _ctx;

        public OwnerRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }
        public Owner Create(Owner owner)
        {
            var newOwner = _ctx.Owners.Add(owner).Entity;
            _ctx.SaveChanges();
            return newOwner;
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
            return _ctx.Owners.FirstOrDefault(c => c.OwnerID == id);
        }

        public IEnumerable<Owner> ReadOwners()
        {
            return _ctx.Owners;
        }
    }
}
