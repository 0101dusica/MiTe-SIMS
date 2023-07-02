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
    public class TouristVerifyQRViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public TouristVerifyQRView TouristVerifyQRView { get; set; }
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
                    QRCodePath = "../Images/qr" + (int)new Random().Next(1, 4) + ".png";
                }
            }
        }

        private string _qRCodePath;
        public string QRCodePath
        {
            get { return _qRCodePath; }
            set
            {
                if (_qRCodePath != value)
                {
                    _qRCodePath = value;
                    OnPropertyChanged(nameof(QRCodePath));
                }
            }
        }
        public ICommand LogOut { get; }

        public TouristVerifyQRViewModel(MainStorage mainStorage, TouristVerifyQRView touristVerifyQRView)
        {
            MainStorage = mainStorage;
            TouristVerifyQRView = touristVerifyQRView;

            Tours = new List<string>();

            foreach (var tour in MainStorage.Tours)
            {
                Tours.Add(tour.Id);
            }

            QRCodePath = "../Images/none.png";

            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void LogOutCommand(object param)
        {
            TouristMainView mainView = new TouristMainView(MainStorage);
            this.TouristVerifyQRView.Hide();
            mainView.Show();
        }


    }
}
