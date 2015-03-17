using HaterDatingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDatingApp
{
    
        public class HaterDatingContext : DbContext
        {
            public DbSet<Profile> Profiles { get; set; }
            public DbSet<Dislike> Dislikes { get; set; }
            public DbSet<Question> Questions { get; set; }
            
        }
}
