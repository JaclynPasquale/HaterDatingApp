using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HaterDatingApp;
using System.Threading.Tasks;
using System.Data.Entity;
using HaterDatingApp.Model;
using System.Data.Entity.Infrastructure;


namespace HaterDatingApp
{
    public class ProfileContext : DbContext
    {

        public ProfileContext(string connection="HaterDatingApp.ProfileContext") : base(connection)
        {

        }

        public DbSet<Profile> Profile { get; set; }
        public DbSet<Question> Dislike { get; set; }
    }
}