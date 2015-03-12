using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaterDatingApp.Repository
{
    public class ProfilesRepository : iProfileRepository
    {
        private ProfilesContext _dbContext;

        public ProfilesRepository()
        {
            _dbContext = new ProfilesContext();
            _dbContext.Profiles.Load();
            _dbContext.Dislikes.Load();
        }
        public ProfilesContext Context()
        {
            return _dbContext;
        }
        

    }
}