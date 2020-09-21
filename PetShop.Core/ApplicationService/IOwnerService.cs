using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationService
{
    public interface IOwnerService
    {
        public Owner newOwner(string ownerName);
        public Owner CreateOwner(Owner owner);
        public Owner EditOwner(Owner ownerid);
        public Owner DeleteOwner(int id);
        public Owner FindOwnerByID(int id);
        public Owner UpdateOwner(int id, Owner owner);
        public List<Owner> GetOwners();
    }
}
