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
        public List<string> TouristUsernames { get; set; }
        public List<string> QRCodes { get; set;}
        public DateTime StartDate { get; set; }
        public Reservation() { }

        public Reservation(string tourId, DateTime startDate)
        {
            TourId = tourId;
            TouristUsernames = new List<string>();
            QRCodes = new List<string>();
            StartDate = startDate;
        }


    }
}
