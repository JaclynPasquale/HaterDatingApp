﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HaterDatingApp;
using HaterDatingApp.Model;
using HaterDatingApp.Repository;

namespace HaterDatingAppTests
{
    [TestClass]
    public class ProfileRepositoryTest
    {
        private static ProfileRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new ProfileRepository();
            repo.Clear();
        }
        [ClassCleanup]
        public void CleanUp()
        {
            repo.Clear();
        }
        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }
        [TestMethod]
        public void TestAddToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Profile());
            Assert.AreEqual(1, repo.GetCount());
        }
        [TestMethod]
        public void MyTestMethod()
        {
            
        }
    }
}
