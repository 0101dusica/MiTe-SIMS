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
    public class GuideMakeAttractionViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public GuideMakeAttractionView GuideMakeAttractionView { get; set; }

        private Atraction _newAtraction;
        public Atraction NewAtraction
        {
            get { return _newAtraction; }
            set
            {
                _newAtraction = value;
                OnPropertyChanged(nameof(NewAtraction));
            }
        }
        public ICommand AddAtraction { get; }
        public ICommand LogOut { get; }
        public GuideMakeAttractionViewModel(MainStorage mainStorage, GuideMakeAttractionView guideMakeAttractionView)
        {
            MainStorage = mainStorage;
            GuideMakeAttractionView = guideMakeAttractionView;

            NewAtraction = new Atraction();

            AddAtraction = new RelayCommand((param) => AddAtractionCommand(param));
            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void AddAtractionCommand(object param)
        {
            MessageBox.Show("Atraction successfully Added!");
        }
        public void LogOutCommand(object param)
        {
            GuideMainView mainView = new GuideMainView(MainStorage);
            this.GuideMakeAttractionView.Hide();
            mainView.Show();
        }
    }
}
