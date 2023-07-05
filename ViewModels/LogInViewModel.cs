using System;
using System.Windows.Input;
using System.Windows;
using MiTe.Storage;
using MiTe.Views;
using MiTe.Models;

namespace MiTe.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public MainWindow LogInView { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; }
        public LoginViewModel(MainStorage mainStorage, MainWindow logInView)
        {
            this.MainStorage = mainStorage;
            this.LogInView = logInView;
            LoginCommand = new RelayCommand((param) => LoggedIn(param));
        }

        private void LoggedIn(object parameters)
        {
            for (int i = 0; i < MainStorage.Guides.Count; i++)
            {
                if (MainStorage.Guides[i].Username == this.Username && MainStorage.Guides[i].Password == this.Password)
                {
                    User user = new User(MainStorage.Guides[i].FirstName, MainStorage.Guides[i].LastName, MainStorage.Guides[i].Username, MainStorage.Guides[i].Password, true);
                    MainStorage.LoggedUser = user;
                    MainStorage.LoggedUser = MainStorage.Guides[i];
                    GuideMainView guideMainView = new GuideMainView(MainStorage);
                    LogInView.Close();
                    guideMainView.Show();
                    return;
                }

            }

            for (int i = 0; i < MainStorage.Tourists.Count; i++)
            {
                if (MainStorage.Tourists[i].Username == this.Username && MainStorage.Tourists[i].Password == this.Password)
                {
                    User user = new User(MainStorage.Tourists[i].FirstName, MainStorage.Tourists[i].LastName, MainStorage.Tourists[i].Username, MainStorage.Tourists[i].Password, true);
                    MainStorage.LoggedUser = user;
                    MainStorage.LoggedUser = MainStorage.Tourists[i];
                    TouristMainView touristMainView = new TouristMainView(MainStorage);
                    LogInView.Close();
                    touristMainView.Show();
                    return;
                }

            }


            for (int i = 0; i < MainStorage.Administrators.Count; i++)
            {
                if (MainStorage.Administrators[i].Username == this.Username && MainStorage.Administrators[i].Password == this.Password)
                {
                    User user = new User(MainStorage.Administrators[i].FirstName, MainStorage.Administrators[i].LastName, MainStorage.Administrators[i].Username, MainStorage.Administrators[i].Password, true);
                    MainStorage.LoggedUser = user;
                    MainStorage.LoggedUser = MainStorage.Administrators[i];
                    AdministratorMainView menuAdministratorView = new AdministratorMainView(MainStorage);
                    LogInView.Close();
                    menuAdministratorView.Show();
                    return;
                }

            }

            MessageBox.Show($"Check again! Your username or password is WRONG!");

        }

    }
    
}
