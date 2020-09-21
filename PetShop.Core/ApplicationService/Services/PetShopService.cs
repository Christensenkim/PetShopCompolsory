using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationService.Services
{
    public class PetShopService : IPetShopService
    {
        private IPetShopRepository _PetRepository;

        public PetShopService(IPetShopRepository petShopRepository)
        {
            _PetRepository = petShopRepository;
        }

        public Pet CreatePet(Pet pet)
        {
            return _PetRepository.Create(pet);
        }

        public Pet DeletePet(int id)
        {
            return _PetRepository.Delete(id);
        }

        public Pet EditPet(Pet petEdit)
        {
            Pet pet = FindPetByID(petEdit.PetId);

            pet.PetName = petEdit.PetName;
            pet.PetType = petEdit.PetType;
            pet.Birthday = petEdit.Birthday;
            pet.SoldDate = petEdit.SoldDate;
            pet.PetColor = petEdit.PetColor;
            pet.PreviousOwner = petEdit.PreviousOwner;
            pet.PetPrice = petEdit.PetPrice;

            return pet;
        }

        public Pet FindPetByID(int id)
        {
            return _PetRepository.GetPetByID(id);
        }

        public List<Pet> FindPetsByType(string searchedType)
        {
            return _PetRepository.FindPetsByType(searchedType);
        }

        public List<Pet> GetListSortedByPrice()
        {
            return _PetRepository.GetListSortedByPrice();
        }

        public List<Pet> GetPets(string petType)
        {
            return _PetRepository.ReadPets(petType);
        }

        public Pet newPet(string petName, string petType, DateTime petBirthday, DateTime petSold, string petColor, string previousOwner, double price)
        {
            var pet = new Pet();

            pet.PetName = petName;
            pet.PetType = petType;
            pet.Birthday = petBirthday;
            pet.SoldDate = petSold;
            pet.PetColor = petColor;
            pet.PreviousOwner = previousOwner;
            pet.PetPrice = price;

            return pet;
        }

        public Pet UpdatePet(int id, Pet updatePet)
        {
            var pet = FindPetByID(id);

            pet.PetName = updatePet.PetName;
            pet.PetType = updatePet.PetType;
            pet.Birthday = updatePet.Birthday;
            pet.SoldDate = updatePet.SoldDate;
            pet.PetColor = updatePet.PetColor;
            pet.PreviousOwner = updatePet.PreviousOwner;
            pet.PetPrice = updatePet.PetPrice;

            return pet;
        }
    }
}
