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
    public class GuideMainViewModel : BaseViewModel
    {
        public GuideMainView GuideMainView { get; set; }
        public MainStorage MainStorage { get; set; }
        public List<Tour> Tours { get; set; }
        public ICommand MakeNewTour { get; }
        public ICommand ReviewTourist { get; }
        public ICommand AddNewAtraction { get; }
        public ICommand ViewProfile { get; }
        public ICommand LogOut { get; }
        public GuideMainViewModel(MainStorage mainStorage, GuideMainView guideMainView) 
        {       
            this.MainStorage = mainStorage;
            this.GuideMainView = guideMainView;
            if(MainStorage.Tours.Count != 0)
            {
                this.Tours = MainStorage.Tours;
            }
            else
            {
                this.Tours = new List<Tour>();
            }

            MakeNewTour = new RelayCommand((param) => MakeNewTourCommand(param));
            ReviewTourist = new RelayCommand((param) => ReviewTouristCommand(param));
            AddNewAtraction = new RelayCommand((param) => AddNewAtractionCommand(param));
            ViewProfile = new RelayCommand((param) => ViewProfileCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void MakeNewTourCommand(object param)
        {
            GuideMakeTourView guideMakeTourView = new GuideMakeTourView(MainStorage);
            this.GuideMainView.Hide();
            guideMakeTourView.Show();
        }
        public void ReviewTouristCommand(object param)
        {
            GuideReviewTouristView guideReviewTouristView = new GuideReviewTouristView(MainStorage);
            this.GuideMainView.Hide();
            guideReviewTouristView.Show();
        }
        public void AddNewAtractionCommand(object param)
        {
            GuideMakeAttractionView guideMakeAttractionView = new GuideMakeAttractionView(MainStorage);
            this.GuideMainView.Hide();
            guideMakeAttractionView.Show();
        }

        public void ViewProfileCommand(object param)
        {
            UserViewProfile mainView = new UserViewProfile(MainStorage);
            this.GuideMainView.Hide();
            mainView.Show();
        }
        public void LogOutCommand(object param)
        {
            MainWindow mainView = new MainWindow();
            this.GuideMainView.Hide();
            mainView.Show();
        }
    }
}
