using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Core.ApplicationService.Services
{
    public class OwnerService : IOwnerService
    {
        private IOwnerRepository _OwnerRepository;

        public OwnerService(IOwnerRepository OwnerRepository)
        {
            _OwnerRepository = OwnerRepository;
        }

        public Owner CreateOwner(Owner owner)
        {
            return _OwnerRepository.Create(owner);
        }

        public Owner DeleteOwner(int id)
        {
            return _OwnerRepository.Delete(id);
        }

        public Owner EditOwner(Owner ownerEdit)
        {
            var owner =  _OwnerRepository.GetOwnerByID(ownerEdit.OwnerID);

            owner.OwnerName = ownerEdit.OwnerName;

            return owner;
        }

        public Owner FindOwnerByID(int id)
        {
            return _OwnerRepository.GetOwnerByID(id);
        }

        public List<Owner> GetOwners()
        {
            return _OwnerRepository.ReadOwners().ToList();
        }

        public Owner newOwner(string ownerName)
        {
            var owner = new Owner();

            owner.OwnerName = ownerName;

            return owner;
        }

        public Owner UpdateOwner(int id, Owner ownerUpdate)
        {
            var owner = FindOwnerByID(id);

            owner.OwnerName = ownerUpdate.OwnerName;

            return owner;
        }
    }
}
