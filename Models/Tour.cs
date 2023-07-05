using MiTe.Storage;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MiTe.Models
{
    public enum Language
    {
        English, Serbian, Spanish, French
    }
    public enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    public enum Category
    {
        Cultural, Adventure, Food, Nature, Historical, Educational, Photography, Wellness
    }
    public enum TourStatus
    {
        Accepted, Rejected, WaitingApproval, Expired
    }

    public class Tour
    {
        public string Id { get; set; }
        public int Capasity { get; set; }
        public Language Language { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<Days> MaintenanceDays { get; set; }
        public List<Stage> Stages { get; set; }
        public string GuideUsername { get; set; }
        public string City { get; set; }
        public List<Category> Category { get; set; }
        public bool Free { get; set; }
        public string ImagePath { get; set; }

        public TourStatus TourStatus { get; set; }
        public Tour() { }
        public Tour(int capasity, Language language, DateOnly startDate, DateOnly endDate, List<Days> maintenanceDays, List<Stage> stages, string guideUsername, string city, List<Category> category, bool free, string imagePath)
        {
            Id = NextId(new MainStorage());
            Capasity = capasity;
            Language = language;
            StartDate = startDate;
            EndDate = endDate;
            MaintenanceDays = maintenanceDays;
            Stages = stages;
            GuideUsername = guideUsername;
            City = city;
            Category = category;
            Free = free;
            ImagePath = imagePath;
            TourStatus = TourStatus.WaitingApproval;
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
            return ("tour" + (lastId + 1).ToString());

        }

        public Tuple<string, double> getAvrageRatings(MainStorage mainStorage)
        {
            double ratingSum = 0;
            int ratingCount = 0;
            
            foreach (var poll in mainStorage.Polls)
            {
                if(poll.ForeignId == this.Id && this.TourStatus == TourStatus.Accepted)
                {
                    foreach(var rate in poll.Answers)
                    {
                        ratingSum = ratingSum + rate;
                        ratingCount++;
                    }
                }
            }

            return Tuple.Create(this.Id, Math.Round(ratingSum/ratingCount, 2));
        }
    }
}
