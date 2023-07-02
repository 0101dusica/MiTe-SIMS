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
    public class TouristReviewGuideViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public TouristReviewGuideView TouristReviewGuideView { get; set; }

        public List<string> Guides { get; set; }

        private string _guidePicked;
        public string? GuidePicked
        {
            get { return _guidePicked; }
            set
            {
                if (_guidePicked != value)
                {
                    _guidePicked = value;
                    OnPropertyChanged(nameof(GuidePicked));
                    GuidePicked = null;
                }
            }
        }

        public List<string> Questions { get; set; }
        public ICommand Submit { get; }
        public ICommand LogOut { get; }

        public TouristReviewGuideViewModel(MainStorage mainStorage, TouristReviewGuideView touristReviewGuideView)
        {
            MainStorage = mainStorage;
            TouristReviewGuideView = touristReviewGuideView;

            Guides = new List<string>();

            foreach (var guide in MainStorage.Guides)
            {
                Guides.Add(guide.Username);
            }

            Questions = new List<string>();

            foreach (var question in MainStorage.Questions)
            {
                if (question.Type == Models.QuestionType.Guide)
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
            this.TouristReviewGuideView.Hide();
            mainView.Show();
        }
    }
}
