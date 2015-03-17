using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDatingApp.Model
{
    public class Dislike
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int QuestionId { get; set; }
        public int QuestionValue { get; set; }

        public virtual Profile profile { get; set; }
    }
    
}