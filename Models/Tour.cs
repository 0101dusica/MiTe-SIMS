using System;
using System.Collections.Generic;

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
        Cultural, Adventure, Food, Sightseeing, Wildlife, Nature, Historical, Educational, Photography, Wellness, Private
    }

    public class Tour
    {
        public string Id { get; set; }
        public int Capasity { get; set; }
        public Language Language { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Days> MaintenanceDays { get; set; }
        public List<Stage> Stages { get; set; }
        public string GuideUsername { get; set; }
        public string City { get; set; }
        public List<Category> Category { get; set; }
        public bool Free { get; set; }
        public Tour() { }
        public Tour(string id, int capasity, Language language, DateTime startDate, DateTime endDate, List<Days> maintenanceDays, List<Stage> stages, string guideUsername, string city, List<Category> category, bool free)
        {
            Id = id;
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
        }
    }
}
