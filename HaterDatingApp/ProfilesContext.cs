using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HaterDatingApp;
using System.Threading.Tasks;
using System.Data.Entity;
using HaterDatingApp.Models;
using System.Data.Entity.Infrastructure;


namespace HaterDatingApp
{
    public class ProfilesContext : DbContext
    {

        public ProfilesContext() : base("ProfilesContext")
        {

        }

        public DbSet<UserProfiles> Profiles { get; set; }
        public DbSet<Dislikes> Dislikes { get; set; }
    }
}