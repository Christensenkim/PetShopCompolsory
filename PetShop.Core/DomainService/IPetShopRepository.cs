using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.Entity;

namespace PetShop.Core.DomainService
{
    public interface IPetShopRepository
    {
        public IEnumerable<Pet> ReadPets(string petType);
        public Pet Create(Pet pet);
        public Pet GetPetByID(int id);
        public Pet EditPet(Pet petEdit);
        public Pet Delete(int id);
        public List<Pet> FindPetsByType(string searchedType);
        List<Pet> GetListSortedByPrice();
    }
}
