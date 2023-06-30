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

        public AdministratorStorage administratorStorage { get; set; }
        public TouristStorage touristStorage { get; set; }
        public GuideStorage guideStorage { get; set; }
        public MainStorage()
        {
            this.Administrators = new List<Administrator>();
            this.Tourists = new List<Tourist>();
            this.Guides = new List<Guide>();

            this.administratorStorage = new AdministratorStorage();
            this.touristStorage = new TouristStorage();
            this.guideStorage = new GuideStorage();
        }

        public void loadAllData()
        {
            this.Administrators = administratorStorage.Load();
            this.Tourists = touristStorage.Load();
            this.Guides = guideStorage.Load();

        }

    }
}
