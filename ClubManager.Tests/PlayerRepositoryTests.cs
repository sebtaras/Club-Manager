using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClubManager.Tests
{
    [TestClass]
    public class PlayerRepositoryTests
    {
        private readonly IPlayerRepository _repo = new PlayerRepository();
        
        [TestMethod]
        public void CreateOne()
        {
            Assert.AreEqual(0, _repo.GetAll().Count);

            Player player = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);
            _repo.Add(player);

            Assert.AreEqual(1, _repo.GetAll().Count);
            Assert.AreEqual(player, _repo.GetPlayerById(player.Id));
        }

        [TestMethod]
        public void DeleteOne()
        {
            Assert.AreEqual(0, _repo.GetAll().Count);

            Player player = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);

            _repo.Add(player);
            Assert.AreEqual(1, _repo.GetAll().Count);

            _repo.Delete(player);
            Assert.AreEqual(0, _repo.GetAll().Count);
        }

        [TestMethod]
        public void DoesPlayerExist()
        {
            Player player = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);
            _repo.Add(player);

            Assert.AreEqual(true, _repo.CheckPlayerExists(player));

        }

        [TestMethod]
        public void NonexistantPlayer()
        {
            Player player = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);
            Assert.AreEqual(false, _repo.CheckPlayerExists(player));

        }

        [TestMethod]
        public void UpdateEmailAndPassword()
        {
            Player player = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);
            _repo.Add(player);
            Assert.AreEqual(player.Email, _repo.GetPlayerById(player.Id).Email);
            Assert.AreEqual(player.Password, _repo.GetPlayerById(player.Id).Password);

            _repo.UpdatePlayerValues(player.Id, "updated@mail", "password", "lozinka");
            Assert.AreEqual(player.Email, _repo.GetPlayerById(player.Id).Email);
            Assert.AreEqual(player.Password, _repo.GetPlayerById(player.Id).Password);
        }

        [TestMethod]
        public void UpdateUsingWrongPassword()
        {
            Player player = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);
            _repo.Add(player);
            Assert.AreEqual(player.Email, _repo.GetPlayerById(player.Id).Email);
            Assert.AreEqual(player.Password, _repo.GetPlayerById(player.Id).Password);

            _repo.UpdatePlayerValues(player.Id, "updated@mail", "wrongpassword", "lozinka");
            Assert.AreNotEqual("updated@mail", _repo.GetPlayerById(player.Id).Email);
            Assert.AreNotEqual("lozinka", _repo.GetPlayerById(player.Id).Password);
        }

        [TestMethod]
        public void VerifyPlayer()
        {
            Player player = new Player(1, "bob", "dasilva", "db@mail", "password", 15, false);
            _repo.Add(player);
            Assert.AreEqual(false, _repo.GetPlayerById(player.Id).Verified);
            
            _repo.Verify(player);
            Assert.AreEqual(true, _repo.GetPlayerById(player.Id).Verified);
        }
    }
}
