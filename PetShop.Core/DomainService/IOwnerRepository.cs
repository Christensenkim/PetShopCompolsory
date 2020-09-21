using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.DomainService
{
    public interface IOwnerRepository
    {
        public List<Owner> ReadOwners();
        public Owner Create(Owner owner);
        public Owner GetOwnerByID(int id);
        public Owner EditOwner(Owner ownerEdit);
        public Owner Delete(int id);
    }
}
