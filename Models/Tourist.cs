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
    }
}
