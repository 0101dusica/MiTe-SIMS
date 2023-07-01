﻿using MiTe.Models;
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
    public class TouristMainViewModel : BaseViewModel
    {
        public TouristMainView TouristMainView { get; set; }
        public MainStorage MainStorage { get; set; }
        public List<Tour> Tours { get; set; }
        public ICommand ReserveTour { get; }
        public ICommand VerifyQR { get; }
        public ICommand GetReservationHistory { get; }
        public ICommand ReviewGuide { get; }
        public ICommand LogOut { get; }
        public TouristMainViewModel(MainStorage mainStorage, TouristMainView touristMainView)
        {
            this.MainStorage = mainStorage;
            this.TouristMainView = touristMainView;
            if (MainStorage.Tours.Count != 0)
            {
                this.Tours = MainStorage.Tours;
            }
            else
            {
                this.Tours = new List<Tour>();
            }

            ReserveTour = new RelayCommand((param) => ReserveTourCommand(param));
            VerifyQR = new RelayCommand((param) => VerifyQRCommand(param));
            GetReservationHistory = new RelayCommand((param) => GetReservationHistoryCommand(param));
            ReviewGuide = new RelayCommand((param) => ReviewGuideCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void ReserveTourCommand(object param)
        {
            MessageBox.Show("ReserveTourCommand");
        }
        public void VerifyQRCommand(object param)
        {
            MessageBox.Show("VerifyQRCommand");
        }
        public void GetReservationHistoryCommand(object param)
        {
            MessageBox.Show("GetReservationHistoryCommand");
        }
        public void ReviewGuideCommand(object param)
        {
            MessageBox.Show("ReviewGuideCommand");
        }
        public void LogOutCommand(object param)
        {
            MainWindow mainView = new MainWindow();
            this.TouristMainView.Hide();
            mainView.Show();
        }
    }
}
