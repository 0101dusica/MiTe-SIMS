using MiTe.Models;
using MiTe.Storage;
using MiTe.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MiTe.ViewModels
{
    public class AdministratorBlockUsersViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public AdministratorBlockUsersView AdministratorBlockUsersView { get; set; }
        public List<Tuple<Guide, double>> Guides { get; set; }

        private Tuple<Guide, double> _selectedRowGuide;
        public Tuple<Guide, double>? SelectedRowGuide
        {
            get { return _selectedRowGuide; }
            set
            {
                if (_selectedRowGuide != value)
                {
                    _selectedRowGuide = value;
                    OnPropertyChanged(nameof(SelectedRowGuide));
                    SelectedRowTourist = null;
                }
            }
        }

        public List<Tuple<Tourist, double>> Tourists { get; set; }

        private Tuple<Tourist, double> _selectedRowTourist;
        public Tuple<Tourist, double>? SelectedRowTourist
        {
            get { return _selectedRowTourist; }
            set
            {
                if (_selectedRowTourist != value)
                {
                    _selectedRowTourist = value;
                    OnPropertyChanged(nameof(SelectedRowTourist));
                    SelectedRowGuide = null;
                }
            }
        }
        public ICommand BlockUser { get; }
        public ICommand LogOut { get; }
        public AdministratorBlockUsersViewModel(MainStorage mainStorage, AdministratorBlockUsersView administratorBlockUsersView)
        {
            MainStorage = mainStorage;
            AdministratorBlockUsersView = administratorBlockUsersView;

            Guides = new List<Tuple<Guide, double>>();
            Tourists = new List<Tuple<Tourist, double>>();

            foreach(var guide in MainStorage.Guides)
            {
                Guides.Add(Tuple.Create(guide, guide.getAvrageRatings(MainStorage).Item2));
            }

            foreach (var tourist in MainStorage.Tourists)
            {
                Tourists.Add(Tuple.Create(tourist, tourist.getAvrageRatings(MainStorage).Item2));
            }


            BlockUser = new RelayCommand((param) => BlockUserCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void BlockUserCommand(object param)
        {
            if(SelectedRowGuide != null)
            {
                MessageBox.Show($"User {SelectedRowGuide.Item1.Username} is BLOCKED!");
            }
            else if (SelectedRowTourist != null)
            {
                MessageBox.Show($"User {SelectedRowTourist.Item1.Username} is BLOCKED!");
            }
            else
            {
                MessageBox.Show("You don't select any row!");
            }

        }

        public void LogOutCommand(object param)
        {
            AdministratorMainView mainView = new AdministratorMainView(MainStorage);
            this.AdministratorBlockUsersView.Hide();
            mainView.Show();
        }
    }
}
