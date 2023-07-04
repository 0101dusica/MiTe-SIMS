using MiTe.Models;
using MiTe.Storage;
using MiTe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace MiTe.ViewModels
{
    public class TourisShowReservationViewModel
    {
        public MainStorage MainStorage { get; set; }
        public TourisShowReservationView TourisShowReservationView { get; set; }

        public List<Reservation> Reservations { get; set; }
        public DateOnly PickDate { get; set; }
        public ICommand AddNew { get; }
        public ICommand Delete { get; }
        public ICommand LogOut { get; }

        public TourisShowReservationViewModel(MainStorage mainStorage, TourisShowReservationView tourisShowReservationView)
        {
            MainStorage = mainStorage;
            TourisShowReservationView = tourisShowReservationView;

            Reservations = new List<Reservation>();

            foreach (var reservation in MainStorage.Reservations)
            {
                Reservations.Add(reservation);
            }

            AddNew = new RelayCommand((param) => AddNewCommand(param));
            Delete = new RelayCommand((param) => DeleteCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void AddNewCommand(object param)
        {
            TouristReserveTourView touristReserveTourView = new TouristReserveTourView(MainStorage);
            this.TourisShowReservationView.Hide();
            touristReserveTourView.Show();
        }

        public void DeleteCommand(object param)
        {
            MessageBox.Show("Successfully deleted Tour!");
        }
        public void LogOutCommand(object param)
        {
            TouristMainView mainView = new TouristMainView(MainStorage);
            this.TourisShowReservationView.Hide();
            mainView.Show();
        }
    }
}
