using Microsoft.EntityFrameworkCore;
using PetShop.Core.Entity;
using System;

namespace PetShop.Infrastructer.SQLite
{
    public class PetShopContext: DbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> opt)
            : base(opt) { }


        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
    }
}
