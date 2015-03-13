﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaterDatingApp;
using HaterDatingApp.Model;
using System.Data.Entity;


namespace HaterDatingApp.Repository
{
    public class ProfileRepository : iProfileRepository
    {
        private ProfileDBContext _dbContext;

        public ProfileRepository()
        {
            _dbContext = new ProfileDBContext();
            _dbContext.Profiles.Load();
            
        }
        public ProfileDBContext Context()
        {
            return _dbContext;
        }

        public DbSet<Model.Profile> GetDbSet()
        {
            return _dbContext.Profiles;
        }

        public int GetCount()
        {
            return _dbContext.Profiles.Count<Model.Profile>();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Delete(Model.Profile P)
        {
            throw new NotImplementedException();
        }

        public void Add(Model.Profile P)
        {
            /* Solution 1:
             * Find if the event is in the DB;
             * 
             * var query = from Event in _dbContext.Events
             * where Event.Date == E.Date and Event.Name == E.Name
             * select Event;
             * 
             * if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Solution 2:
             * 
             * Migration on the table, adding another field. Like, a hash (Name+Date).
             * 
             * var gimme_hash = Sha1.Create(E.Name+E.Date);
             * gimme_hash.Hash;
             * _dbContext.Event.Find(e => e.Hash == E.hash);
             * _dbContext.Event.SingleOrDefault(e => e.Hash == E.hash);
             * OR use LINQ
             * 
             *if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Thinking forward, we want the UI window handling the Event addition to tell the user they
             * can't add duplicates
             * */
            _dbContext.Profiles.Add(P);
            _dbContext.SaveChanges();
        }
        public Model.Profile GetById(string id)
        {
            var query = from Profile in _dbContext.Profiles
                        where Profile.ApplicationUserId == id
                        select Profile;
            return query.First<Model.Profile>();

        }
        public void Clear()
        {
            var a = this.All();
            _dbContext.Profiles.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Model.Profile> All()
        {
            // First look to see if the stash is populated. If so
            // then return that stash otherwise do what's below.
            var qu = from Event in _dbContext.Profiles select Event;
            return qu.ToList<Model.Profile>();
        }

        public IQueryable<Model.Profile> SearchFor(System.Linq.Expressions.Expression<Func<Model.Profile, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }


        

    }
}