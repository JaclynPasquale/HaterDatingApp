using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaterDatingApp.Model
{
    public class Profile
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        private string LastName { get; set; }
        public string Location { get; set; }
        private string Email { get; set; }
        public Int16 Age { get; set; }
        public bool Female { get; set; }
        public bool Male { get; set; }
        public bool IntoMen { get; set; }
        public bool IntoWomen { get; set; }
        public Int16 HeightInInches { get; set; }
        public byte[] Picture { get; set; }

    }
}