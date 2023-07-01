using MiTe.Models;
using MiTe.Storage;
using MiTe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.ViewModels
{
    public class AdministratorBlockUsersViewModel
    {
        public MainStorage MainStorage { get; set; }
        public AdministratorBlockUsersView AdministratorBlockUsersView { get; set; }
        public List<Tuple<Guide, double>> Guides { get; set; }
        public List<Tuple<Tourist, double>> Tourists { get; set; }

        public Tuple<Tourist, double> SelectedRow { get; set; }
        public AdministratorBlockUsersViewModel(MainStorage mainStorage, AdministratorBlockUsersView administratorBlockUsersView)
        {
            MainStorage = mainStorage;
            AdministratorBlockUsersView = administratorBlockUsersView;

            //logic for making table with users (guides, tourists)
        }
    }
}
