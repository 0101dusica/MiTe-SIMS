using MiTe.Storage;
using MiTe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.ViewModels
{
    public class TouristVerifyQRViewModel
    {
        public MainStorage MainStorage { get; set; }
        public TouristVerifyQRView TouristVerifyQRView { get; set; }

        public TouristVerifyQRViewModel(MainStorage mainStorage, TouristVerifyQRView touristVerifyQRView)
        {
            MainStorage = mainStorage;
            TouristVerifyQRView = touristVerifyQRView;
        }
    }
}
