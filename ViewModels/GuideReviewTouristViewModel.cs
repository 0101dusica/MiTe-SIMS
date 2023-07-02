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
    public class GuideReviewTouristViewModel
    {
        public MainStorage MainStorage { get; set; }
        public GuideReviewTouristView GuideReviewTouristView { get; set; }
        public List<string> Questions { get; set; }
        ICommand Submit { get; }
        ICommand LogOut { get; }
        public GuideReviewTouristViewModel(MainStorage mainStorage, GuideReviewTouristView guideReviewTouristView)
        {
            MainStorage = mainStorage;
            GuideReviewTouristView = guideReviewTouristView;

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
