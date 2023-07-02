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
    public class TouristMainViewModel : BaseViewModel
    {
        public TouristMainView TouristMainView { get; set; }
        public MainStorage MainStorage { get; set; }
        public List<Tour> Tours { get; set; }
        public ICommand ReserveTour { get; }
        public ICommand VerifyQR { get; }
        public ICommand ReviewTour { get; }
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
            ReviewTour = new RelayCommand((param) => ReviewTourCommand(param));
            ReviewGuide = new RelayCommand((param) => ReviewGuideCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void ReserveTourCommand(object param)
        {
            TouristReserveTourView mainView = new TouristReserveTourView(MainStorage);
            this.TouristMainView.Hide();
            mainView.Show();
        }
        public void VerifyQRCommand(object param)
        {
            TouristVerifyQRView mainView = new TouristVerifyQRView(MainStorage);
            this.TouristMainView.Hide();
            mainView.Show();
        }
        public void ReviewTourCommand(object param)
        {
            TouristReviewTourView mainView = new TouristReviewTourView(MainStorage);
            this.TouristMainView.Hide();
            mainView.Show();
        }
        public void ReviewGuideCommand(object param)
        {
            TouristReviewGuideView mainView = new TouristReviewGuideView(MainStorage);
            this.TouristMainView.Hide();
            mainView.Show();
        }
        public void LogOutCommand(object param)
        {
            TouristMainView mainView = new TouristMainView(MainStorage);
            this.TouristReviewTourView.Hide();
            mainView.Show();
        }
    }
}
