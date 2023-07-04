using MiTe.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{
    public class Guide : User
    {
        public List<string> Tours { get; set; }

        public Guide()
        {
            Tours = new List<string>();
        }
        
        public Tuple<string, double> getAvrageRatings(MainStorage mainStorage)
        {
            double ratingSum = 0;
            int ratingCount = 0;

            foreach (var poll in mainStorage.Polls)
            {
                if (poll.ForeignId == this.Username)
                {
                    foreach (var rate in poll.Answers)
                    {
                        ratingSum = ratingSum + rate;
                        ratingCount++;
                    }
                }
            }

            return Tuple.Create(this.Username, Math.Round(ratingSum / ratingCount, 2));
        }
    }
}
