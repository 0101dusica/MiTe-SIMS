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
    public class TouristReserveTourViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public TouristReserveTourView TouristReserveTourView { get; set; }
        public ICommand Submit { get; }
        public ICommand LogOut { get; }

        public TouristReserveTourViewModel(MainStorage mainStorage, TouristReserveTourView touristReserveTourView)
        {
            MainStorage = mainStorage;
            TouristReserveTourView = touristReserveTourView;


            Submit = new RelayCommand((param) => SubmitCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void SubmitCommand(object param)
        {
            MessageBox.Show("Submitted successfully!");
        }
        public void LogOutCommand(object param)
        {
            GuideMainView mainView = new GuideMainView(MainStorage);
            this.TouristReserveTourView.Hide();
            mainView.Show();
        }
    }
}
