﻿using MiTe.Storage;
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
    public class AdministratorMainViewModel :BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public AdministratorMainView AdministratorMainView { get; set; }
        public ICommand RemoveTour { get; }
        public ICommand AcceptTour { get; }
        public ICommand Analytics { get; }
        public ICommand BlockUser { get; }
        public AdministratorMainViewModel(MainStorage mainStorage, AdministratorMainView administratorMainView) 
        {
            MainStorage = mainStorage;
            AdministratorMainView = administratorMainView;
            RemoveTour = new RelayCommand((param) => RemoveTourCommand(param));
            AcceptTour = new RelayCommand((param) => AcceptTourCommand(param));
            Analytics = new RelayCommand((param) => AnalyticsCommand(param));
            BlockUser = new RelayCommand((param) => BlockUserCommand(param));
        }

        public void RemoveTourCommand(object param)
        {
            MessageBox.Show("RemoveTour");
        }

        public void AcceptTourCommand(object param)
        {
            MessageBox.Show("AcceptTour");
        }
        public void AnalyticsCommand(object param)
        {
            MessageBox.Show("Analytics");
        }
        public void BlockUserCommand(object param)
        {
            MessageBox.Show("BlockUser");
        }
    }
}