using ClubManager.BaseLib;
using ClubManager.DAL_File;
using ClubManager.Models;
using ClubManager.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClubManager.Contrllers
{
    public class TrainerController : ITrainerController
    {
        public void Homepage(ITrainerView form, IMainController inController, Trainer inTrainer, ITrainerRepository trainerRepository, ITrainingRepository trainingRepository, ITeamRepository teamRepository, IPlayerRepository playerRepository)
        {
            form.ShowViewModaless(inController, inTrainer);
            form.DisplayPlayerList(playerRepository.GetAll(), teamRepository.GetAll());
            form.DisplayTrainingList(trainingRepository.GetAll(), teamRepository.GetAll());
        }

        public bool ShowCreateTraining(ITrainerCreateTrainingView form, Trainer trainer, ITrainingRepository trainingRepository, ITeamRepository teamRepository)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                if (form.TeamName() != "" && VerifyTrainingInput(form.Duration) && !Occupied(form.StartTime, trainingRepository))
                {
                    int teamID = -1;
                    foreach (Team t in teamRepository.GetAll())
                    {
                        if (t.Name == form.TeamName()) teamID = t.Id;
                    }
                    if (teamID == -1) return false;
                    TimeSpan durationTimeSpan = new TimeSpan(0, int.Parse(form.Duration), 0);
                    Training training = new Training(trainingRepository.GetNextID(), form.StartTime, durationTimeSpan, teamID, trainer.Id);
                    trainingRepository.Add(training);
                    int trainingID = trainingRepository.GetNextID() - 1;
                    foreach (Team t in teamRepository.GetAll())
                    {
                        if (t.Id == teamID) t.ListTrainingIds.Add(trainingID);
                    }
                    return true;
                }
                return false;
            }
            return true;
        }

        public bool DeleteTraining(ITrainerDeleteTrainingView form, ITrainingRepository trainingRepository, ITeamRepository teamRepository, int trainingId)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                trainingRepository.Delete(trainingId);
                foreach (Team t in teamRepository.GetAll())
                {
                    if (t.ListTrainingIds.Contains(trainingId))
                    {
                        t.ListTrainingIds.Remove(trainingId);
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Occupied(DateTime startTime, ITrainingRepository trainingRepository)
        {
            foreach (Training t in trainingRepository.GetAll())
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

        public bool ShowTrainerSettings(ISettingsTrainerView form, Trainer trainer, ITrainerRepository trainerRepository, IAuthController authController)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                if (authController.VerifyUpdateUserInput(form.Email, form.PasswordCurrent, form.PasswordNew))
                    return trainerRepository.UpdateTrainerValues(trainer, form.Email, form.PasswordCurrent, form.PasswordNew);
                else
                    return false;
            }
            return true;
        }
    }
}
