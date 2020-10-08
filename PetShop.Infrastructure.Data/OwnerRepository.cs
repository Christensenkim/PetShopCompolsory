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
            owner.OwnerID = _fakeDB.GetDBID();

            _fakeDB.AddOwnerToList(owner);

            return owner;
        }

        public Owner Delete(int id)
        {
            var ownerFound = this.GetOwnerByID(id);
            if(ownerFound != null)
            {
                _fakeDB.RemoveOwnerFromList(ownerFound);
                return ownerFound;
            }
            return null;
        }

        public Owner EditOwner(Owner ownerEdit)
        {
            var ownerFromDB = this.GetOwnerByID(ownerEdit.OwnerID);

            if (ownerFromDB != null)
            {
                ownerFromDB.OwnerName = ownerEdit.OwnerName;

                return ownerFromDB;
            }
            return null;
        }

        public Owner GetOwnerByID(int id)
        {
            foreach (var owner in _fakeDB.GetListOfOwners())
            {
                if(owner.OwnerID == id)
                {
                    return owner;
                }
            }
            return null;
        }

        public IEnumerable<Owner> ReadOwners()
        {
            return _fakeDB.GetListOfOwners();
        }
    }
}
