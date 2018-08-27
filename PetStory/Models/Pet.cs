using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStory.Models
{
    public class Pet
    {
        public int ID { set; get; }
        public string name { set; get; }
        public string animalType { set; get; }
        //public virtual Owner owner { set; get; }
        public double age { set; get; }
        public string image { set; get; }

    }
}


