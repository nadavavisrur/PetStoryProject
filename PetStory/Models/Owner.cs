using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStory.Models
{
    public class Owner
    {
        public int ID { set; get; }
        public string facebookID { set; get; }
        public string name { set; get; }
        public DateTime birthday { set; get; } //parse as daytime object
        //public virtual List<Owner> friends { set; get; }
        public string city { set; get; }
        //public virtual List<Pet> pets { set; get; }
        public string image { set; get; }

        /*public Owner()
        {
            this.friends = new List<Owner>();
            this.pets = new List<Pet>();
            
        }*/
        //need to add image from facebook profile


    }
}
