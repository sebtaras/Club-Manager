using ClubManager.DAL_File;
using ClubManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClubManager.Tests
{
    [TestClass]
    public class PlayerRepositoryTests
    {
        [TestMethod]
        public void AddToPlayerRepository()
        {
            PlayerRepository pr = new PlayerRepository();
            Assert.AreEqual(0, pr._listPlayers.Count);

            Player p = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);

            pr.Add(p);
            Assert.AreEqual(1, pr._listPlayers.Count);
        }

        [TestMethod]
        public void DeleteFromPlayerRepository()
        {
            PlayerRepository pr = new PlayerRepository();
            Assert.AreEqual(0, pr._listPlayers.Count);

            Player p = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);

            pr.Add(p);
            Assert.AreEqual(1, pr._listPlayers.Count);

            pr.Delete(p);
            Assert.AreEqual(0, pr._listPlayers.Count);
        }

        [TestMethod]
        public void DoesPlayerExist()
        {
            PlayerRepository pr = new PlayerRepository();
            Player p = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);
            pr.Add(p);

            Assert.AreEqual(true, pr.CheckPlayerExists(p));

        }

        [TestMethod]
        public void DoesNonExistantPlayerExist()
        {
            PlayerRepository pr = new PlayerRepository();
            Player p = new Player(1, "bob", "dasilva", "db@mail", "password", 15, true);

            Assert.AreEqual(false, pr.CheckPlayerExists(p));

        }
    }
}
