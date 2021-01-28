using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClubManager.Contrllers
{
    class TrainerController : ITrainerController
    {
        public void Homepage(ITrainerView form, IMainController inController, Trainer inTrainer, TrainerRepository trainerRepository, TrainingRepository trainingRepository, TeamRepository teamRepository, PlayerRepository playerRepository)
        {
            form.ShowViewModaless(inController, inTrainer, teamRepository, trainingRepository, playerRepository);
        }

        public bool ShowCreateTraining(ITrainerCreateTrainingView form, Trainer trainer, TrainingRepository trainingRepository, TeamRepository teamRepository)
        {
            var result = form.ShowViewModal();
            if(result == DialogResult.OK)
            {
                if(form.TeamName() != "" && VerifyTrainingInput(form.Duration) && !Occupied(form.StartTime, trainingRepository))
                {
                    int teamID = -1;
                    foreach(Team t in teamRepository._teamList)
                    {
                        if (t._name == form.TeamName()) teamID = t.Id;
                    }
                    if (teamID == -1) return false;
                    TimeSpan durationTimeSpan = new TimeSpan(0, int.Parse(form.Duration), 0);
                    Training training = new Training(trainingRepository.next_ID, form.StartTime, durationTimeSpan, teamID, trainer.Id);
                    trainingRepository.Add(training);
                    int trainingID = trainingRepository.next_ID - 1;
                    foreach(Team t in teamRepository._teamList)
                    {
                        if (t.Id == teamID) t._listTrainingIds.Add(trainingID);
                    }
                    return true;
                }
                return false;
            }
            return false;
        }

        private bool Occupied(DateTime startTime, TrainingRepository trainingRepository)
        {
            foreach(Training t in trainingRepository._trainings)
            {
                if (startTime < t.EndTime && startTime > t.StartTime)
                    return true;
            }
            return false;
        }

        private bool VerifyTrainingInput(string duration)
        {
            if (!ValidationFunctions.IsValidTrainingDuration(duration))
                return false;
            return true;
        }
    }
}
