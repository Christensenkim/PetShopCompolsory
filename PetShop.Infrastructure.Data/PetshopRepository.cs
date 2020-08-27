using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;

namespace PetShop.Infrastructure.Data
{
    public class PetshopRepository : IPetShopRepository
    {
        
        private FakeDB _fakeDB = new FakeDB();

        public Pet Create(Pet pet)
        {
            pet.PetId = _fakeDB.GetDBID();
            _fakeDB.AddPetToList(pet);
            return pet;
        }

        public Pet Delete(int id)
        {
            var petFound = this.GetPetByID(id);
            if (petFound != null)
            {
                _fakeDB.RemovePetFromList(petFound);
                return petFound;
            }
            return null;
        }

        public Pet EditPet(Pet petEdit)
        {
            var petFromDB = this.GetPetByID(petEdit.PetId);

            if (petFromDB != null)
            {
                petFromDB.PetName = petEdit.PetName;
                petFromDB.PetType = petEdit.PetType;
                petFromDB.Birthday = petEdit.Birthday;
                petFromDB.SoldDate = petEdit.SoldDate;
                petFromDB.PetColor = petEdit.PetColor;
                petFromDB.PreviousOwner = petEdit.PreviousOwner;
                petFromDB.PetPrice = petEdit.PetPrice;

                return petFromDB;
            }
            return null;
        }

        public List<Pet> FindPetsByType(string searchedType)
        {
            List<Pet> listofSearchedPetByType = new List<Pet>();
            foreach (var pet in _fakeDB.GetListOfPets())
            {
                if(pet.PetType == searchedType)
                {
                    listofSearchedPetByType.Add(pet);
                }
            }
            return listofSearchedPetByType;
        }

        public List<Pet> GetListSortedByPrice()
        {
            List<Pet> petsToBeSortedByPrice = _fakeDB.GetListOfPets();

            petsToBeSortedByPrice.Sort((x, y) => x.PetPrice.CompareTo(y.PetPrice));

            return petsToBeSortedByPrice;
        }

        public Pet GetPetByID(int id)
        {
            foreach (var pet in _fakeDB.GetListOfPets())
            {
                if (pet.PetId == id)
                {
                    return pet;
                }
            }
            return null;
        }

        public List<Pet> ReadPets()
        {
            return _fakeDB.GetListOfPets();
        }
    }
}
