using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDatingApp.Model
{
    public class Question
    {
        public int ID { get; set; }
        public string QuestionName { get; set; } 
    }
    public class QuestionDBContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
    }
}