using MiTe.Storage;
using MiTe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MiTe.ViewModels
{
    public class AdministratorAnalyticsViewModel : BaseViewModel
    {
        public MainStorage MainStorage { get; set; }
        public AdministratorAnalyticsView AdministratorAnalyticsView { get; set; }

        public List<Tuple<string, double>> Tours { get; set; }
        public List<Tuple<string, double>> Tourists { get; set; }
        public List<Tuple<string, double>> Guides { get; set; }
        public ICommand LogOut { get; set; }
        public AdministratorAnalyticsViewModel(MainStorage mainStorage, AdministratorAnalyticsView administratorMainView) 
        {
            MainStorage = mainStorage;
            AdministratorAnalyticsView = administratorMainView;

            Tours = new List<Tuple<string, double>>();
            foreach(var tour in mainStorage.Tours)
            {
                Tours.Add(tour.getAvrageRatings(mainStorage));
            }

            Tourists = new List<Tuple<string, double>>();
            foreach (var tourist in mainStorage.Tourists)
            {
                Tourists.Add(tourist.getAvrageRatings(mainStorage));
            }

            Guides = new List<Tuple<string, double>>();
            foreach (var guide in mainStorage.Guides)
            {
                Guides.Add(guide.getAvrageRatings(mainStorage));
            }


            LogOut = new RelayCommand((param) => LogOutCommand(param));
        }

        public void LogOutCommand(object param)
        {
            AdministratorMainView administratorMainView = new AdministratorMainView(MainStorage);
            this.AdministratorAnalyticsView.Hide();
            administratorMainView.Show();
        }
    }
}
