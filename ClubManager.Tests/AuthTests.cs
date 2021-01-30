using ClubManager.BaseLib;
using ClubManager.Contrllers;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.PresentationLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Tests
{
    [TestClass]
    public class AuthTests
    {
        private readonly IMainController controller = new MainController(
            new WindowFormsFactory(),
            new PlayerRepository(),
            new TrainerRepository(),
            new AdminRepository(),
            new TrainingRepository(),
            new TeamRepository(),
            new TransactionRepository(),
            new AdminController(),
            new PlayerController(),
            new TrainerController(),
            new AuthController()
            );

        [TestMethod]
        public void RegisterPlayerIncorrectEmail()
        {
            Assert.AreEqual(false, controller.RegisterUser("badEmail", "password", "first", "name", "Player", "15"));
        }

        [TestMethod]
        public void RegisterPlayerPasswordUnder6Chars()
        {
            Assert.AreEqual(false, controller.RegisterUser("shortpw@mail", "pass", "first", "name", "Player", "15"));
        }

        [TestMethod]
        public void RegisterPlayerAgeUnder6()
        {
            Assert.AreEqual(false, controller.RegisterUser("under6@mail", "password", "name", "lastname", "Player", "5"));
        }
        [TestMethod]
        public void RegisterPlayerAgeOver30()
        {
            Assert.AreEqual(false, controller.RegisterUser("over30@mail", "password", "name", "lastname", "Player", "31"));
        }

        [TestMethod]
        public void RegisterPlayerNoRoleSelected()
        {
            Assert.AreEqual(false, controller.RegisterUser("norole@mail", "password", "name", "lastname", "", "15"));
        }

        [TestMethod]
        public void RegisterPlayerSuccessfully()
        {
            Assert.AreEqual(true, controller.RegisterUser("andy@mail", "password", "name", "lastname", "Player", "15"));
        }

        [TestMethod]
        public void RegisterPlayerExistingEmail()
        {
            Assert.AreEqual(true, controller.RegisterUser("andy@mail", "password", "name", "lastname", "Player", "15"));
            Assert.AreEqual(false, controller.RegisterUser("andy@mail", "password2", "name2", "lastname2", "Player", "16"));
        }

        [TestMethod]
        public void LogInUserEmptyEmail()
        {
            Assert.AreEqual(true, controller.RegisterUser("andy@mail", "password", "name", "lastname", "Player", "15"));
            Assert.AreEqual(false, controller.LogInUser("", "password"));
        }

        [TestMethod]
        public void LoginUserIncorrectCredentials()
        {
            Assert.AreEqual(true, controller.RegisterUser("andy@mail", "password", "name", "lastname", "Player", "15"));
            Assert.AreEqual(false, controller.LogInUser("andy@mail", "wrongpassword"));
        }

        [TestMethod]
        public void LoginUserSuccessfully()
        {
            Assert.AreEqual(true, controller.RegisterUser("andy@mail", "password", "name", "lastname", "Player", "15"));
            Assert.AreEqual(true, controller.LogInUser("andy@mail", "password"));
        }
    }
}
