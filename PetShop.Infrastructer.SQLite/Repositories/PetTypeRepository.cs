using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructer.SQLite.Data.Repositories
{
    class PetTypeRepository : IPetTypeRepository
    {
        readonly PetShopContext _ctx;

        public PetTypeRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }
        public PetType Create(PetType petType)
        {
            throw new NotImplementedException();
        }

        public PetType Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PetType EditPetType(PetType ownerEdit)
        {
            throw new NotImplementedException();
        }

        public PetType GetPetTypeByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<PetType> ReadTypes()
        {
            throw new NotImplementedException();
        }
    }
}
