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
    public class GuideMakeTourViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public GuideMakeTourView GuideMakeTourView { get; set; }

        private Tour newTour;
        public Tour NewTour
        {
            get { return newTour; }
            set
            {
                newTour = value;
                OnPropertyChanged(nameof(NewTour));
            }
        }
        public List<Language> Languages { get; set; }
        public List<bool> Free { get; set; }
        public List<Days> DaysList { get; set; }
        public List<Category> CategoryList { get; set; }
        public ICommand AddTour { get; }
        public ICommand LogOut { get; }
        public GuideMakeTourViewModel(MainStorage mainStorage, GuideMakeTourView guideMakeTourView) 
        {
            MainStorage = mainStorage;
            GuideMakeTourView = guideMakeTourView;

            NewTour = new Tour();
            Languages = new List<Language>(Enum.GetValues(typeof(Language)) as Language[]);
            Free = new List<bool> { true, false };
            DaysList = new List<Days>(Enum.GetValues(typeof(Days)) as Days[]);
            CategoryList = new List<Category>(Enum.GetValues(typeof(Category)) as Category[]);


            AddTour = new RelayCommand((param) => AddTourCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void AddTourCommand(object param)
        {
            MessageBox.Show("Tour successfully Added!");
        }
        public void LogOutCommand(object param)
        {
            GuideMainView mainView = new GuideMainView(MainStorage);
            this.GuideMakeTourView.Hide();
            mainView.Show();
        }
    }
}
