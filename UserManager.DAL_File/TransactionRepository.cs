using ClubManager.Models;
using ClubManager.Models.Repositories;
using ClubManager.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File
{
    public class TransactionRepository : ITransactionRepository
    {
        public int next_ID = 1;
        public List<Transaction> _listTransactions = new List<Transaction>();

        public bool Add(Transaction transaction)
        {
            transaction.Id = next_ID;
            _listTransactions.Add(transaction);

            var mySession = SessionGetter.OpenSession();
            using (ITransaction trans = mySession.BeginTransaction())
            {
                mySession.Save(transaction);
                trans.Commit();
            }

            next_ID++;
            return true;
        }

        public IList<Transaction> GetAll()
        {
            IList<Transaction> list;
            var mySession = SessionGetter.OpenSession();
            using (ITransaction trans = mySession.BeginTransaction())
            {
                list = mySession.CreateQuery("from " + typeof(Transaction)).List<Transaction>();
                trans.Commit();
            }
            return list;
            //return _listTransactions;
        }

        public int GetNextId()
        {
            return next_ID;
        }

        public void Delete(Transaction transaction)
        {
            _listTransactions.Remove(transaction);

            var mySession = SessionGetter.OpenSession();
            using (ITransaction trans = mySession.BeginTransaction())
            {
                mySession.Delete(transaction);
                mySession.Flush();
                trans.Commit();
            }
        }

        public Transaction GetTransactionById(int id)
        {
            Transaction res; 
            var mySession = SessionGetter.OpenSession();
            using (ITransaction trans = mySession.BeginTransaction())
            {
                res = mySession.Get<Transaction>(id);
                trans.Commit();
            }
            return res;
            //return _listTransactions.Find(t => t.Id == id);
        }

        public void ChangeTransactionStatus(Transaction transaction)
        {
            foreach(Transaction t in _listTransactions)
            {
                if(t.Id == transaction.Id)
                {
                    t.Paid = !t.Paid;
                    var mySession = SessionGetter.OpenSession();
                    using (ITransaction trans = mySession.BeginTransaction())
                    {
                        mySession.SaveOrUpdate(t);
                        trans.Commit();
                    }
                    return;
                }
            }
        }
    }
}
