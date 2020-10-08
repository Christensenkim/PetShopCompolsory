using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public PetType CreateType(PetType petType)
        {
            return _PetTypeRepository.Create(petType);
        }

        public PetType DeleteType(int id)
        {
            return _PetTypeRepository.Delete(id);
        }

        public PetType EditType(PetType petTypeID)
        {
            PetType petType = FindTypeByID(petTypeID.TypeID);

            petType.Type = petTypeID.Type;

            return petType;
        }

        public PetType FindTypeByID(int id)
        {
            return _PetTypeRepository.GetPetTypeByID(id);
        }

        public List<PetType> GetTypes()
        {
            return _PetTypeRepository.ReadTypes().ToList();
        }

        public PetType newType(string ownerName)
        {
            var petType = new PetType()
            {
                Type = ownerName
            };

            return petType;
        }

        public PetType UpdateType(int id, PetType petTypeUpdate)
        {
            var petType = FindTypeByID(id);

            petType.Type = petTypeUpdate.Type;

            return petType;
        }
    }
}
