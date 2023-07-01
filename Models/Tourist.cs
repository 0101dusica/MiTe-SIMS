using MiTe.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{

    public class Tourist : User
    {
        public List<Category> Interests { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
        public List<string> QRCodes { get; set; }
        public int Points { get; set; }
        public bool Subscription { get; set; }


        public Tourist() { }

        public Tourist(string phoneNumber, string email, bool subscription)
        {
            this.Interests = new List<Category>();
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.ProfileImage = "";
            this.QRCodes = new List<string>();
            this.Points = 0;
            this.Subscription = subscription;
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
