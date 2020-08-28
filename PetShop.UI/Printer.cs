using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.ApplicationService;
using PetShop.Core.Entity;

namespace PetShop.UI
{
    class Printer : IPrinter
    {
        IPetShopService _petShopService;

        public Printer(IPetShopService petShopService)
        {
            _petShopService = petShopService;
        }

        public void StartUI()
        {
            Console.WriteLine("Welcome To PetShop");
            Console.WriteLine("1: Create a pet");
            Console.WriteLine("2: List pets");
            Console.WriteLine("3: Edit pet");
            Console.WriteLine("4: Delete Pet");
            Console.WriteLine("5: Search pet by type");
            Console.WriteLine("6: Sort pets by price from low to high");
            Console.WriteLine("7: List the 5 cheapest pets");

            Console.WriteLine("0: Exit");
            string optionChoosen = Console.ReadLine();
            bool isNumber = int.TryParse(optionChoosen, out int number);

            if (isNumber)
            {
                int choosenOption = int.Parse(optionChoosen);
                while(choosenOption > 0)
                {
                    switch (choosenOption)
                    {
                        case 1:
                            Console.WriteLine("Name of the pet?");
                            string petName = Console.ReadLine();
                            Console.WriteLine("What type is the pet?");
                            string petType = Console.ReadLine();
                            Console.WriteLine("What date was the pet born? (YYYY-MM-DD)");
                            DateTime petBirthday = ValidDateTime();
                            Console.WriteLine("What date was the pet sold? (YYYY-MM-DD)");
                            DateTime petSoldDate = ValidDateTime();
                            Console.WriteLine("What color is the pet?");
                            string petColer = Console.ReadLine();
                            Console.WriteLine("Who was the previous owner of the pet?");
                            string previousOwner = Console.ReadLine();
                            Console.WriteLine("what is the price of the pet?");
                            double petPrice = double.Parse(Console.ReadLine());

                            Pet newPet = _petShopService.newPet(petName, petType, petBirthday, petSoldDate, petColer, previousOwner, petPrice);
                            _petShopService.CreatePet(newPet);
                            Console.WriteLine("Pet has been created!");

                            StartUI();
                            break;
                        case 2:
                            Console.WriteLine("Pet list\n");
                            var pets = _petShopService.GetPets();
                            ListPets(pets);

                            StartUI();
                            break;
                        case 3:
                            var petIdToEdit = PrintFindPetID();
                            var petToEdit = _petShopService.FindPetByID(petIdToEdit);
                            Console.WriteLine($"Pet Choosen to update: {petToEdit.PetName}");
                            Console.WriteLine("Pet pame");
                            var newName = Console.ReadLine();
                            Console.WriteLine("Pet type");
                            var newtype = Console.ReadLine();
                            Console.WriteLine("Pet birthday");
                            var newBirthday = ValidDateTime();
                            Console.WriteLine("Pet salesdate");
                            var newSoldDay = ValidDateTime();
                            Console.WriteLine("Pet Coler");
                            var newColor = Console.ReadLine();
                            Console.WriteLine("Previous Owner");
                            var newPreviousOwner = Console.ReadLine();
                            Console.WriteLine("Pet Price");
                            var newPrice = double.Parse(Console.ReadLine());

                            _petShopService.UpdatePet(new Pet()
                            {
                                PetId = petIdToEdit,
                                PetName = newName,
                                PetType = newtype,
                                Birthday = newBirthday,
                                SoldDate = newSoldDay,
                                PetColor = newColor,
                                PreviousOwner = newPreviousOwner,
                                PetPrice = newPrice
                            });


                            StartUI();
                            break;
                        case 4:
                            var petIdToDelete = PrintFindPetID();
                            _petShopService.DeletePet(petIdToDelete);

                            StartUI();
                            break;

                        case 5:
                            Console.WriteLine("Type of pet to search");
                            var searchedType = Console.ReadLine();
                            List<Pet> listOfPetsWithSearchedType = _petShopService.FindPetsByType(searchedType);
                            ListPets(listOfPetsWithSearchedType);

                            StartUI();
                            break;

                        case 6:
                            List<Pet> sortedByPrice = _petShopService.GetListSortedByPrice();
                            ListPets(sortedByPrice);

                            StartUI();
                            break;

                        case 7:
                            List<Pet> sortedByPrice5 = _petShopService.GetListSortedByPrice();
                            List5Pets(sortedByPrice5);

                            StartUI();
                            break;
                        default:
                            break;
                    }
                    break;
                }
                
            }
            else
            {
                Console.WriteLine("Please input a valide number from the option menu");
                StartUI();
            }

            void ListPets(List<Pet> pets)
            {
                Console.WriteLine("\nList of Movies");
                foreach (var pet in pets)
                {
                    Console.WriteLine($" Pet ID: {pet.PetId} \n " +
                        $"Pet Name: {pet.PetName} \n " +
                        $"Pet Type: {pet.PetType} \n " +
                        $"Pet Birthday: {pet.Birthday} \n " +
                        $"Pet Sold: {pet.SoldDate} \n " +
                        $"Pet color: {pet.PetColor} \n " +
                        $"Previous Owner: {pet.PreviousOwner} \n " +
                        $"Pet Price: {pet.PetPrice} \n");
                }
                Console.WriteLine("\n");
            }

            void List5Pets(List<Pet> pets)
            {
                for (int i = 0; i < 5; i++)
                {
                    var pet = pets[i];
                    Console.WriteLine($" Pet ID: {pet.PetId} \n " +
                        $"Pet Name: {pet.PetName} \n " +
                        $"Pet Type: {pet.PetType} \n " +
                        $"Pet Birthday: {pet.Birthday} \n " +
                        $"Pet Sold: {pet.SoldDate} \n " +
                        $"Pet color: {pet.PetColor} \n " +
                        $"Previous Owner: {pet.PreviousOwner} \n " +
                        $"Pet Price: {pet.PetPrice} \n");
                }
            }

            int PrintFindPetID()
            {
                Console.WriteLine("Type a Pet ID : ");
                int id;
                while(!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Not a valid ID");
                }
                return id;
            }

            DateTime ValidDateTime()
            {
                DateTime datetime;
                while (!DateTime.TryParse(Console.ReadLine(), out datetime))
                {
                    Console.WriteLine("Not a valid date, try again (YYYY-MM-DD)");
                }
                return datetime;
            }
        }
    }
}
