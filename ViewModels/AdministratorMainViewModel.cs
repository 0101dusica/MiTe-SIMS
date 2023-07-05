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
    public class AdministratorMainViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public AdministratorMainView AdministratorMainView { get; set; }
        public ICommand ManageTours { get; }
        public ICommand Analytics { get; }
        public ICommand BlockUser { get; }
        public ICommand ViewProfile { get; }
        public ICommand LogOut { get; }
        public AdministratorMainViewModel(MainStorage mainStorage, AdministratorMainView administratorMainView) 
        {
            MainStorage = mainStorage;
            AdministratorMainView = administratorMainView;
            ManageTours = new RelayCommand((param) => ManageToursCommand(param));
            Analytics = new RelayCommand((param) => AnalyticsCommand(param));
            BlockUser = new RelayCommand((param) => BlockUserCommand(param));
            ViewProfile = new RelayCommand((param) => ViewProfileCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void ManageToursCommand(object param)
        {
            AdministratorManageToursView administratorManageToursView = new AdministratorManageToursView(MainStorage);
            this.AdministratorMainView.Hide();
            administratorManageToursView.Show();
        }

        public void AnalyticsCommand(object param)
        {
            AdministratorAnalyticsView administratorAnalyticsView = new AdministratorAnalyticsView(MainStorage);
            this.AdministratorMainView.Hide();
            administratorAnalyticsView.Show();
        }
        public void BlockUserCommand(object param)
        {
            AdministratorBlockUsersView administratorBlockUsersView = new AdministratorBlockUsersView(MainStorage);
            this.AdministratorMainView.Hide();
            administratorBlockUsersView.Show();
        }

        public void ViewProfileCommand(object param)
        {
            UserViewProfile mainView = new UserViewProfile(MainStorage);
            this.AdministratorMainView.Hide();
            mainView.Show();
        }

        public void LogOutCommand(object param)
        {
            MainWindow mainView = new MainWindow();
            this.AdministratorMainView.Hide();
            mainView.Show();
        }
    }
}
