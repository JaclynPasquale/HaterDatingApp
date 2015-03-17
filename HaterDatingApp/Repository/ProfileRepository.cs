﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaterDatingApp;
using System.Data.Entity;
using HaterDatingApp.Model;



namespace HaterDatingApp.Repository
{
    public class ProfileRepository : iProfileRepository
    {
        private HaterDatingContext _dbContext;


        public ProfileRepository()
        {
            
            _dbContext = new HaterDatingContext();
            _dbContext.Profiles.Load();
            _dbContext = new HaterDatingContext();
            _dbContext.Questions.Load();
        }
        public HaterDatingContext Context()
        {
            return _dbContext;
        }
        //public QuestionDBContext Context()
        //{
        //    return dbContextQ;
        //}

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
            var a = this.GetAll();
            _dbContext.Profiles.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IQueryable<Model.Profile> GetAll()
        {
            // First look to see if the stash is populated. If so
            // then return that stash otherwise do what's below.
            //var qu = from Profiles in _dbContext.Profiles select Profiles;
            //return qu.ToList<Model.Profile>();
            return _dbContext.Profiles;
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