using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationService
{
    public interface ITypeService
    {
        public PetType newType(string ownerName);
        public PetType CreateType(Pet pet);
        public PetType EditType(Pet petID);
        public PetType DeleteType(int id);
        public PetType FindTypeByID(int id);
        public PetType UpdateType(int id, Pet pet);
        public List<PetType> GetTypes();
    }
}
