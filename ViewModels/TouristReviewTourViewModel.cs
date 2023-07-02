using MiTe.Storage;
using MiTe.Views;
using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace MiTe.ViewModels
{
    public class TouristReviewTourViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public TouristReviewTourView TouristReviewTourView { get; set; }
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
        public ICommand Submit { get; }
        public ICommand LogOut { get; }

        public TouristReviewTourViewModel(MainStorage mainStorage, TouristReviewTourView touristReviewTourView)
        {
            MainStorage = mainStorage;
            TouristReviewTourView = touristReviewTourView;

            Tours = new List<string>();

            foreach (var tour in MainStorage.Tours)
            {
                Tours.Add(tour.Id);
            }

            Questions = new List<string>();

            foreach (var question in MainStorage.Questions)
            {
                if (question.Type == QuestionType.Tour)
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
            TouristMainView mainView = new TouristMainView(MainStorage);
            this.TouristReviewTourView.Hide();
            mainView.Show();
        }
    }
}
