using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.Entity;

namespace PetShop.Infrastructure.Data
{
    public class FakeDB
    {
        static int id = 1;
        public static List<Pet> listOfPets = new List<Pet>();

        public static void InitData()
        {
            Pet pet1 = new Pet()
            {
                PetId = id++,
                PetName = "Max",
                PetType = "Dog",
                Birthday = DateTime.Parse("2000-01-01"),
                SoldDate = DateTime.Parse("2001-02-03"),
                PetColor = "brown",
                PreviousOwner = "Someone Cool",
                PetPrice = 2000
            };
            listOfPets.Add(pet1);

            Pet pet2 = new Pet()
            {
                PetId = id++,
                PetName = "Mox",
                PetType = "Cat",
                Birthday = DateTime.Parse("2002-01-01"),
                SoldDate = DateTime.Parse("2003-02-03"),
                PetColor = "Black",
                PreviousOwner = "Someone Rad",
                PetPrice = 1200
            };
            listOfPets.Add(pet2);

            Pet pet3 = new Pet()
            {
                PetId = id++,
                PetName = "Mix",
                PetType = "Goat",
                Birthday = DateTime.Parse("2005-01-01"),
                SoldDate = DateTime.Parse("2005-02-03"),
                PetColor = "Gray",
                PreviousOwner = "Someone Fantastic",
                PetPrice = 1000
            };
            listOfPets.Add(pet3);

            Pet pet4 = new Pet()
            {
                PetId = id++,
                PetName = "Knud",
                PetType = "Goat",
                Birthday = DateTime.Parse("2005-01-01"),
                SoldDate = DateTime.Parse("2005-02-03"),
                PetColor = "Purple",
                PreviousOwner = "Someone Exotic",
                PetPrice = 800
            };
            listOfPets.Add(pet4);

            Pet pet5 = new Pet()
            {
                PetId = id++,
                PetName = "Bing",
                PetType = "Dog",
                Birthday = DateTime.Parse("2005-01-01"),
                SoldDate = DateTime.Parse("2005-02-03"),
                PetColor = "Yellow",
                PreviousOwner = "Someone wierd",
                PetPrice = 3000
            };
            listOfPets.Add(pet5);

            Pet pet6 = new Pet()
            {
                PetId = id++,
                PetName = "Bong",
                PetType = "Cat",
                Birthday = DateTime.Parse("2005-01-01"),
                SoldDate = DateTime.Parse("2005-02-03"),
                PetColor = "Blue",
                PreviousOwner = "Haircolering Salesman",
                PetPrice = 200
            };
            listOfPets.Add(pet6);
        }

        public List<Pet> GetListOfPets()
        {
            return listOfPets;
        }

        public void AddPetToList(Pet pet)
        {
            listOfPets.Add(pet);
        }

        public void RemovePetFromList(Pet pet)
        {
            listOfPets.Remove(pet);
        }

        public int GetDBID()
        {
            return id;
        }
    }
}
