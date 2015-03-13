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
        private ProfileContext _dbContext;

        public ProfileRepository()
        {
            _dbContext = new ProfileContext();
            _dbContext.Profile.Load();
            _dbContext.Dislike.Load();
        }
        public ProfileContext Context()
        {
            return _dbContext;
        }

        public int GetCount()
        {
            return _dbContext.Profile.Count<Model.Profile>();
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
            _dbContext.Profile.Add(P);
            _dbContext.SaveChanges();
        }
        public Model.Profile GetById(string id)
        {
            var query = from Profile in _dbContext.Profile
                        where Profile.ApplicationUserId == id
                        select Profile;
            return query.First<Model.Profile>();

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