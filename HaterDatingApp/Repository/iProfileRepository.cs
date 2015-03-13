using HaterDatingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaterDatingApp.Repository
{
    interface iProfileRepository
    {
        int GetCount(); //
        void Add(Profile E); //
        void Delete(Profile E); //
        void Clear(); //
        IEnumerable<Profile> All(); //
        Profile GetById(string id); //
       
        IQueryable<Profile> SearchFor(Expression<Func<Profile, bool>> predicate);

    }
}
