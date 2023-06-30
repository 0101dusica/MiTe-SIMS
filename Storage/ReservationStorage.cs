using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Storage
{
    public class ReservationStorage
    {
        private const string StoragePath = "../../../Data/Reservations.json";

        private Serializer<Reservation> _serializer;


        public ReservationStorage()
        {
            _serializer = new Serializer<Reservation>();
        }

        public List<Reservation> Load()
        {
            return _serializer.FromJSON(StoragePath);
        }

        public void Save(List<Reservation> reservations)
        {
            _serializer.ToJSON(StoragePath, reservations);
        }
    }
}
