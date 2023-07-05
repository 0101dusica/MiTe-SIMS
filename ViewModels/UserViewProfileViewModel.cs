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
    public class UserViewProfileViewModel
    {
        public MainStorage MainStorage { get; set; }
        public UserViewProfile UserViewProfile { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string ImagePath { get; set; }
        public ICommand ChangeInfo { get; }
        public ICommand ChangePassword { get; }
        public ICommand LogOut { get; }

        public UserViewProfileViewModel(MainStorage mainStorage, UserViewProfile userViewProfile)
        {
            MainStorage = mainStorage;
            UserViewProfile = userViewProfile;

            FirstName = MainStorage.LoggedUser.FirstName;
            LastName = MainStorage.LoggedUser.LastName;
            Username = MainStorage.LoggedUser.Username;

            ImagePath = "../Images/profilePicture.png"; 

            ChangeInfo = new RelayCommand((param) => ChangeInfoCommand(param));
            ChangePassword = new RelayCommand((param) => ChangePasswordCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));

        }

        public void ChangeInfoCommand(object param)
        {
            MessageBox.Show("ChangeInfoCommand!");
        }

        public void ChangePasswordCommand(object param)
        {
            MessageBox.Show("ChangePasswordCommand");
        }
        public void LogOutCommand(object param)
        {
            MainWindow mainView = new MainWindow();
            this.UserViewProfile.Hide();
            mainView.Show();
        }
    }
}
