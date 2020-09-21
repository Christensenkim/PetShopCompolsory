using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.ApplicationService.Services
{
    public class PetTypeService : ITypeService
    {
        private IPetTypeRepository _PetTypeRepository;

        public PetTypeService(IPetTypeRepository PetTypeRepository)
        {
            _PetTypeRepository = PetTypeRepository;
        }

        public PetType CreateType(Pet pet)
        {
            throw new NotImplementedException();
        }

        public PetType DeleteType(int id)
        {
            throw new NotImplementedException();
        }

        public PetType EditType(Pet petID)
        {
            throw new NotImplementedException();
        }

        public PetType FindTypeByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<PetType> GetTypes()
        {
            throw new NotImplementedException();
        }

        public PetType newType(string ownerName)
        {
            throw new NotImplementedException();
        }

        public PetType UpdateType(int id, Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
