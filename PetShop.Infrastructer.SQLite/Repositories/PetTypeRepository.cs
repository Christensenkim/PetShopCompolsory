using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructer.SQLite.Data.Repositories
{
    public class PetTypeRepository : IPetTypeRepository
    {
        readonly PetShopContext _ctx;

        public PetTypeRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }
        public PetType Create(PetType petType)
        {
            var newType = _ctx.PetTypes.Add(petType).Entity;
            _ctx.SaveChanges();
            return newType;
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
            return _ctx.PetTypes.FirstOrDefault(c => c.TypeID == id);
        }

        public IEnumerable<PetType> ReadTypes()
        {
            return _ctx.PetTypes;
        }
    }
}
