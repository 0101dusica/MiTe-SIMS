using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{
    public class Guide : User
    {
        public double AverageRating { get; set; }
        public List<Tour> Tours { get; set; }

        public Guide() { }

        public Guide(double averageRating)
        {
            AverageRating = averageRating;
            Tours = new List<Tour>();
        }
    }
}
