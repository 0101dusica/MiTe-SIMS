using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MiTe.Storage
{
    public class MainStorage
    {
        public User LoggedUser { get; set; }
        public List<Administrator>? Administrators { get; set; }
        public List<Tourist>? Tourists { get; set; }
        public List<Guide>? Guides { get; set; }
        public List<Tour>? Tours { get; set; }
        public List<Atraction>? Atractions { get; set; }
        public List<Reservation>? Reservations { get; set; }
        public List<Poll>? Polls { get; set; }
        public List<Questions>? Questions { get; set; }

        public AdministratorStorage administratorStorage { get; set; }
        public TouristStorage touristStorage { get; set; }
        public GuideStorage guideStorage { get; set; }
        public TourStorage tourStorage { get; set; }
        public AtractionStorage atractionStorage { get; set; }
        public ReservationStorage reservationStorage { get; set; }
        public PollStorage pollStorage { get; set; }
        public QuestionsStorage questionsStorage { get; set; }
        public MainStorage()
        {
            this.Administrators = new List<Administrator>();
            this.Tourists = new List<Tourist>();
            this.Guides = new List<Guide>();
            this.Tours = new List<Tour>();
            this.Atractions = new List<Atraction>();
            this.Reservations = new List<Reservation>();
            this.Polls = new List<Poll>();
            this.Questions = new List<Questions>();

            this.administratorStorage = new AdministratorStorage();
            this.touristStorage = new TouristStorage();
            this.guideStorage = new GuideStorage();
            this.tourStorage = new TourStorage();
            this.atractionStorage = new AtractionStorage();
            this.reservationStorage = new ReservationStorage();
            this.pollStorage = new PollStorage();
            this.questionsStorage = new QuestionsStorage();
        }

        public void loadAllData()
        {
            this.Administrators = administratorStorage.Load();
            this.Tourists = touristStorage.Load();
            this.Guides = guideStorage.Load();
            this.Tours = tourStorage.Load();
            this.Atractions = atractionStorage.Load();
            this.Reservations = reservationStorage.Load();
            this.Polls = pollStorage.Load();
            this.Questions = questionsStorage.Load();
        }

    }
}
