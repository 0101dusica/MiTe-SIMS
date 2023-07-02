using MiTe.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{
    public class Atraction
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }

        public Atraction() { }
        public Atraction(string title, string description, string address, string city, string country, string image) 
        {
            Id = NextId(new MainStorage());
            Title = title;
            Description = description;
            Address = address;
            City = city;
            Country = country;
            Image = image;
        }

        public string NextId(MainStorage mainStorage)
        {
            string id = "";
            int lastId;

            if (mainStorage.Tours.Count == 0)
            {
                lastId = 0;
            }
            else
            {
                foreach (Tour tourStorage in mainStorage.Tours)
                {
                    id = tourStorage.Id;
                }

                lastId = int.Parse(System.Text.RegularExpressions.Regex.Replace(id, @"[^\d]+", ""));

            }
            return ("atraction" + (lastId + 1).ToString());

        }
    }
}
