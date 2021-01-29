using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClubManager.BaseLib
{
    public interface ITrainerCreateTrainingView
    {
        DialogResult ShowViewModal();
        DateTime StartTime { get; }
        string Duration { get; }
        string TeamName();
        void LoadData(Trainer trainer, List<Team> teams);
    }
}
