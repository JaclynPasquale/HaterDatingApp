using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDatingApp.Model
{
    public class Dislike
    {
        public int ID { get; set; }
        public Int16 UserId { get; set; }
        public int QuestionId { get; set; }
        public int QuestionValue { get; set; }
    }
    public class DisklikeDBContext : DbContext
    {
        public DbSet<Dislike> Movies { get; set; }
    }
}