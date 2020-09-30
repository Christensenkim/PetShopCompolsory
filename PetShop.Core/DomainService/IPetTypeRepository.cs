using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.DomainService
{
    public interface IPetTypeRepository
    {
        public IEnumerable<PetType> ReadTypes();
        public PetType Create(PetType petType);
        public PetType GetPetTypeByID(int id);
        public PetType EditPetType(PetType ownerEdit);
        public PetType Delete(int id);
    }
}
