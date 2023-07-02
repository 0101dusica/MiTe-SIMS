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
    public class GuideReviewTouristViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public GuideReviewTouristView GuideReviewTouristView { get; set; }
        public List<string> Tourists { get; set; }

        private string _touristPicked;
        public string? TouristPicked
        {
            get { return _touristPicked; }
            set
            {
                if (_touristPicked != value)
                {
                    _touristPicked = value;
                    OnPropertyChanged(nameof(TouristPicked));
                    TouristPicked = null;
                }
            }
        }

        public List<string> Questions { get; set; }
        public ICommand Submit { get; }
        public ICommand LogOut { get; }
        public GuideReviewTouristViewModel(MainStorage mainStorage, GuideReviewTouristView guideReviewTouristView)
        {
            MainStorage = mainStorage;
            GuideReviewTouristView = guideReviewTouristView;

            Tourists = new List<string>();

            foreach(var tourist in MainStorage.Tourists)
            {
                Tourists.Add(tourist.Username);
            }

            Questions = new List<string>();

            foreach(var question in MainStorage.Questions)
            {
                if(question.Type == Models.QuestionType.Tourist)
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
            this.GuideReviewTouristView.Hide();
            mainView.Show();
        }
    }
}
