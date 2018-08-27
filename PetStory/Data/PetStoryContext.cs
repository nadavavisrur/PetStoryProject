using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetStory.Models;

namespace PetStory.Models
{
    public class PetStoryContext : DbContext
    {
        public PetStoryContext (DbContextOptions<PetStoryContext> options)
            : base(options)
        {
        }

        public DbSet<PetStory.Models.Owner> Owner { get; set; }

        public DbSet<PetStory.Models.Park> Park { get; set; }

        public DbSet<PetStory.Models.Pet> Pet { get; set; }
    }
}
