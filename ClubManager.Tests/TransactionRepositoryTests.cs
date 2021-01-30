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
    public class TransactionRepositoryTests
    {
        private readonly ITransactionRepository _repo = new TransactionRepository();

        [TestMethod]
        public void CreateOne()
        {
            Assert.AreEqual(0, _repo.GetAll().Count);

            Transaction transaction = new Transaction(1, (decimal)200.00, 1, 2020, 3);
            _repo.Add(transaction);

            Assert.AreEqual(1, _repo.GetAll().Count);
            Assert.AreEqual(transaction, _repo.GetTransactionById(transaction.Id));
        }

        [TestMethod]
        public void CreateMultiple()
        {
            Assert.AreEqual(0, _repo.GetAll().Count);

            Transaction transaction1 = new Transaction(1, (decimal)200.00, 1, 2020, 3);
            Transaction transaction2 = new Transaction(1, (decimal)200.00, 1, 2020, 3);
            _repo.Add(transaction1);
            _repo.Add(transaction2);

            Assert.AreEqual(2, _repo.GetAll().Count);
            Assert.AreEqual(transaction1, _repo.GetTransactionById(transaction1.Id));
            Assert.AreEqual(transaction2, _repo.GetTransactionById(transaction2.Id));
        }

        [TestMethod]
        public void UpdateTransactionStatus()
        {
            Transaction transaction1 = new Transaction(1, (decimal)200.00, 1, 2020, 3);
            _repo.Add(transaction1);
            Assert.AreEqual(false, _repo.GetTransactionById(transaction1.Id).Paid);

            _repo.ChangeTransactionStatus(transaction1);
            Assert.AreEqual(true, _repo.GetTransactionById(transaction1.Id).Paid);

            _repo.ChangeTransactionStatus(transaction1);
            Assert.AreEqual(false, _repo.GetTransactionById(transaction1.Id).Paid);
        }

        [TestMethod]
        public void DeleteOne()
        {
            Transaction transaction1 = new Transaction(1, (decimal)200.00, 1, 2020, 3);
            _repo.Add(transaction1);
            Assert.AreEqual(1, _repo.GetAll().Count);
            _repo.Delete(transaction1);
            Assert.AreEqual(0, _repo.GetAll().Count);
        }
    }
}
