using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationService
{
    public interface IOwnerService
    {
        public Owner newOwner(string ownerName);
        public Owner CreateOwner(Pet pet);
        public Owner EditOwner(Pet petID);
        public Owner DeleteOwner(int id);
        public Owner FindOwnerByID(int id);
        public Owner UpdateOwner(int id, Pet pet);
        public List<Owner> FindOwnerByType(string searchedType);
        public List<Owner> GetOwners();
    }
}
