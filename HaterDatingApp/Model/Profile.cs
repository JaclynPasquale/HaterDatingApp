using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDatingApp.Model
{
    public class Profile
    {
        public int ID { get; set; }
        public string ApplicationUserId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        private string LastName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string City { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string State { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        private string Email { get; set; }
        [Required]
        public Int16 Age { get; set; }
        
        public bool Female { get; set; }
        public bool Male { get; set; }
        public bool IntoMen { get; set; }
        public bool IntoWomen { get; set; }

        public Int16 HeightInInches { get; set; }
        public byte[] Picture { get; set; }

    }
    public class ProfileDBContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}