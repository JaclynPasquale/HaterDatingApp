using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDatingApp.Model
{
    public class Question
    {
        public Question()
        {

        }
        public int Id { get; set; }
        public string QuestionName { get; set; } 
    }
   
}