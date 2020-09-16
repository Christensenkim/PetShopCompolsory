using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationService
{
    public interface IPetShopService
    {
        public Pet newPet(string petName, string petType, DateTime petBirthday, DateTime petSold, string petColor, string previousOwner, double price);
        public Pet CreatePet(Pet pet);
        public Pet EditPet(Pet petID);
        public Pet DeletePet(int id);
        public Pet FindPetByID(int id);
        public Pet UpdatePet(int id, Pet pet);
        public List<Pet> FindPetsByType(string searchedType);
        public List<Pet> GetListSortedByPrice();

        public List<Pet> GetPets();
    }
}
