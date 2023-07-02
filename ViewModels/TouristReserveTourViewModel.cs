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
        public List<string> Tours { get; set; }

        private string _tourPicked;
        public string? TourPicked
        {
            get { return _tourPicked; }
            set
            {
                if (_tourPicked != value)
                {
                    _tourPicked = value;
                    OnPropertyChanged(nameof(TourPicked));
                    TourPicked = null;
                }
            }
        }

        public List<string> Questions { get; set; }
        ICommand Submit { get; }
        ICommand LogOut { get; }

        public TouristReserveTourViewModel(MainStorage mainStorage, TouristReserveTourView touristReserveTourView)
        {
            MainStorage = mainStorage;
            TouristReserveTourView = touristReserveTourView;

            Tours = new List<string>();

            foreach (var tour in MainStorage.Tours)
            {
                Tours.Add(tour.Id);
            }

            Questions = new List<string>();

            foreach (var question in MainStorage.Questions)
            {
                if (question.Type == Models.QuestionType.Tourist)
                {
                    Questions = question.TextQuestions;
                }
            }

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
