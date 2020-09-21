using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;

namespace PetShop.Infrastructure.Data
{
    public class PetTypeRepository : IPetTypeRepository
    {
        private FakeDB _fakeDB = new FakeDB();

        public PetType Create(PetType petType)
        {
            petType.TypeID = _fakeDB.GetDBID();
            _fakeDB.AddTypeToList(petType);
            return petType;
        }

        public PetType Delete(int id)
        {
            var petTypeFound = this.GetPetTypeByID(id);

            if(petTypeFound != null)
            {
                _fakeDB.RemoveTypeFromList(petTypeFound);
                return petTypeFound;
            }
            return null;
        }

        public PetType EditPetType(PetType petTypeEdit)
        {
            var petTypeFromDB = this.GetPetTypeByID(petTypeEdit.TypeID);

            if(petTypeFromDB != null)
            {
                petTypeFromDB.Type = petTypeEdit.Type;

                return petTypeFromDB;
            }
            return null;
        }

        public PetType GetPetTypeByID(int id)
        {
            foreach (var petType in _fakeDB.GetListOfTypes())
            {
                if(petType.TypeID == id)
                {
                    return petType;
                }
            }
            return null;
        }

        public List<PetType> ReadTypes()
        {
            return _fakeDB.GetListOfTypes();
        }
    }
}
