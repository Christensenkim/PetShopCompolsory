using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
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

        public Owner CreateOwner(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Owner DeleteOwner(int id)
        {
            throw new NotImplementedException();
        }

        public Owner EditOwner(Pet petID)
        {
            throw new NotImplementedException();
        }

        public Owner FindOwnerByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Owner> FindOwnerByType(string searchedType)
        {
            throw new NotImplementedException();
        }

        public List<Owner> GetOwners()
        {
            throw new NotImplementedException();
        }

        public Owner newOwner(string ownerName)
        {
            throw new NotImplementedException();
        }

        public Owner UpdateOwner(int id, Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
