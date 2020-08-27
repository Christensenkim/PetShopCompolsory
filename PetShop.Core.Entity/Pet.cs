using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Entity
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime SoldDate { get; set; }
        public string PetColor { get; set; }
        public string PreviousOwner { get; set; }
        public double PetPrice { get; set; }
    }
}
