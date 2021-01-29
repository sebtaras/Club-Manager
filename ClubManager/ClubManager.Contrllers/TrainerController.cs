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
    class TrainerController : ITrainerController
    {
        public void Homepage(ITrainerView form, IMainController inController, Trainer inTrainer, TrainerRepository trainerRepository, TrainingRepository trainingRepository, TeamRepository teamRepository, PlayerRepository playerRepository)
        {
            form.ShowViewModaless(inController, inTrainer);
            form.DisplayPlayerList(playerRepository._listPlayers, teamRepository._teamList);
            form.DisplayTrainingList(trainingRepository._trainings, teamRepository._teamList);
        }

        public bool ShowCreateTraining(ITrainerCreateTrainingView form, Trainer trainer, TrainingRepository trainingRepository, TeamRepository teamRepository)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                if (form.TeamName() != "" && VerifyTrainingInput(form.Duration) && !Occupied(form.StartTime, trainingRepository))
                {
                    int teamID = -1;
                    foreach (Team t in teamRepository._teamList)
                    {
                        if (t.Name == form.TeamName()) teamID = t.Id;
                    }
                    if (teamID == -1) return false;
                    TimeSpan durationTimeSpan = new TimeSpan(0, int.Parse(form.Duration), 0);
                    Training training = new Training(trainingRepository.next_ID, form.StartTime, durationTimeSpan, teamID, trainer.Id);
                    trainingRepository.Add(training);
                    int trainingID = trainingRepository.next_ID - 1;
                    foreach (Team t in teamRepository._teamList)
                    {
                        if (t.Id == teamID) t.ListTrainingIds.Add(trainingID);
                    }
                    return true;
                }
                return false;
            }
            return true;
        }

        public bool DeleteTraining(ITrainerDeleteTrainingView form, TrainingRepository trainingRepository, TeamRepository teamRepository, int trainingId)
        {
            var result = form.ShowViewModal();
            if (result == DialogResult.OK)
            {
                trainingRepository.Delete(trainingId);
                foreach (Team t in teamRepository._teamList)
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

        private bool Occupied(DateTime startTime, TrainingRepository trainingRepository)
        {
            foreach (Training t in trainingRepository._trainings)
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
                    return trainerRepository.UpdatePlayerValues(trainer, form.Email, form.PasswordCurrent, form.PasswordNew);
                else
                    return false;
            }
            return true;
        }
    }
}
