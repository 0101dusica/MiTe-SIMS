using MiTe.Storage;
using MiTe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.ViewModels
{
    public class TouristReviewTourViewModel
    {
        public MainStorage MainStorage { get; set; }
        public TouristReviewTourView TouristReviewTourView { get; set; }

        public TouristReviewTourViewModel(MainStorage mainStorage, TouristReviewTourView touristReviewTourView)
        {
            MainStorage = mainStorage;
            TouristReviewTourView = touristReviewTourView;
        }
    }
}
