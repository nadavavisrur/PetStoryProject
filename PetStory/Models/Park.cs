using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStory.Models
{
    public class Park
    {
        public int ID { set; get; }
        public string name { set; get; }
        public int zipCode { set; get; }
        public string address { set; get; }
        //public List<String> facilities { set; get; }
        public int likes { set; get; }

    }
}
