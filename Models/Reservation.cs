using MiTe.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MiTe.Models
{
    public class Reservation
    {
        public string TourId { get; set; }
        public string TouristUsernames { get; set; }
        public int NumberOfPeople { get; set; }
        public string QRCodes { get; set;}
        public DateTime StartDate { get; set; }
        public Reservation() { }

        public Reservation(string tourId, string touristId, DateTime startDate)
        {
            TourId = tourId;
            TouristUsernames = touristId;
            NumberOfPeople = 1;
            QRCodes = "";
            StartDate = startDate;
        }


    }
}
