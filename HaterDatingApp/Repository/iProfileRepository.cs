using HaterDatingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaterDatingApp.Repository
{
    interface iProfileRepository
    {
        int GetCount(); //
        void Add(UserProfiles E); //
        void Delete(UserProfiles E); //
        void Clear(); //
        IEnumerable<UserProfiles> PastUserProfiless(); //
        int CalculateMonth(UserProfiles E); //
        IEnumerable<UserProfiles> All(); //
        UserProfiles GetById(int id); //
        UserProfiles GetByDate(string date); //
        //IQueryable<UserProfiles> SearchFor(Expression<Func<UserProfiles, bool>> predicate);

    }
}
