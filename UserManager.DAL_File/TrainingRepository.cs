using ClubManager.Models;
using ClubManager.Models.Repositories;
using ClubManager.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File
{
    public class TrainingRepository : ITrainingRepository
    {
        public int next_ID = 1;
        public List<Training> _trainings = new List<Training>();

        public bool Add(Training training)
        {
            training.Id = next_ID;
            _trainings.Add(training);

/*            var mySession = NHibernateHelper.OpenSession();
            using (ITransaction trans = mySession.BeginTransaction())
            {
                mySession.Save(training);
                trans.Commit();
            }*/
            next_ID++;
            return true;
        }

        public IList<Training> GetAll()
        {
/*            IList<Training> list;
            var mySession = NHibernateHelper.OpenSession();
            using (ITransaction trans = mySession.BeginTransaction())
            {
                list = mySession.CreateQuery("from " + typeof(Training)).List<Training>();
                trans.Commit();
            }
            return list;*/
            return _trainings;
        }
        public int GetNextID()
        {
            return next_ID;
        }

        public void Delete(Training training)
        {
            _trainings.RemoveAll(t => t.Id == training.Id);
/*            Training toDelete;
            var mySession = NHibernateHelper.OpenSession();
            using (ITransaction trans = mySession.BeginTransaction())
            {
                toDelete = mySession.Get<Training>(training.Id);
                mySession.Delete(toDelete);
                mySession.Flush();
                trans.Commit();
            }*/
        }

        public Training GetTrainingById(int trainingId)
        {
/*            Training res;
            var mySession = NHibernateHelper.OpenSession();
            using (ITransaction trans = mySession.BeginTransaction())
            {
                res = mySession.Get<Training>(trainingId);
                trans.Commit();
            }
            return res;*/
            return _trainings.Find(t => t.Id == trainingId);
        }

    }
}
