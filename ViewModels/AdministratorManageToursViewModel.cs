using MiTe.Models;
using MiTe.Storage;
using MiTe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MiTe.ViewModels
{
    public class AdministratorManageToursViewModel
    {
        public MainStorage MainStorage { get; set; }
        public AdministratorManageToursView AdministratorManageToursView { get; set; }
        public List<Tour> Tours { get; set; }
        public ICommand AcceptTour { get; }
        public ICommand RejectTour { get; }
        public ICommand LogOut { get; }
        public AdministratorManageToursViewModel(MainStorage mainStorage, AdministratorManageToursView administratorManageToursView)
        {
            MainStorage = mainStorage;
            AdministratorManageToursView = administratorManageToursView;
            Tours = new List<Tour>();
            foreach (Tour tour in MainStorage.Tours) 
            {
                Tours.Add(tour);
            }

            AcceptTour = new RelayCommand((param) => AcceptTourCommand(param));
            RejectTour = new RelayCommand((param) => RejectTourCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void AcceptTourCommand(object param)
        {
            MessageBox.Show("Successfully ACCEPTED Tour!");
        }

        public void RejectTourCommand(object param)
        {
            MessageBox.Show("Successfully REJECTED Tour!");
        }

        public void LogOutCommand(object param)
        {
            AdministratorMainView mainView = new AdministratorMainView(MainStorage);
            this.AdministratorManageToursView.Hide();
            mainView.Show();
        }
    }
}
