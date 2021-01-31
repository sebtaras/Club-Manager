using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Tests
{
    [TestClass]
    public class TrainingRepositoryTests
    {
        private readonly ITrainingRepository _repo = new TrainingRepository();

        [TestMethod]
        public void CreateOne()
        {
            Assert.AreEqual(0, _repo.GetAll().Count);
            
            Training training = new Training(1, DateTime.Now, new TimeSpan(0, 60, 0), new Team(), new Trainer());
            _repo.Add(training);

            Assert.AreEqual(1, _repo.GetAll().Count);
            Assert.AreEqual(training, _repo.GetTrainingById(training.Id));
        }

        [TestMethod]
        public void CreateMultiple()
        {
            Assert.AreEqual(0, _repo.GetAll().Count);
            
            Training training1 = new Training(1, DateTime.Now, new TimeSpan(0, 60, 0), new Team(), new Trainer());
            Training training2 = new Training(1, DateTime.Now, new TimeSpan(0, 60, 0), new Team(), new Trainer());
            _repo.Add(training1);
            _repo.Add(training2);

            Assert.AreEqual(2, _repo.GetAll().Count);
            Assert.AreEqual(training1, _repo.GetTrainingById(training1.Id));
            Assert.AreEqual(training2, _repo.GetTrainingById(training2.Id));
        }

        [TestMethod]
        public void DeleteOne()
        {
            Training training1 = new Training(1, DateTime.Now, new TimeSpan(0, 60, 0), new Team(), new Trainer());
            _repo.Add(training1);
            Assert.AreEqual(1, _repo.GetAll().Count);
            _repo.Delete(training1);
            Assert.AreEqual(0, _repo.GetAll().Count);
        }
    }
}
