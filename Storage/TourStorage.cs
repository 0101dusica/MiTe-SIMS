using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Storage
{
    public class TourStorage
    {
        private const string StoragePath = "../../../Data/Tours.json";

        private Serializer<Tour> _serializer;


        public TourStorage()
        {
            _serializer = new Serializer<Tour>();
        }

        public List<Tour> Load()
        {
            return _serializer.FromJSON(StoragePath);
        }

        public void Save(List<Tour> tours)
        {
            _serializer.ToJSON(StoragePath, tours);
        }
    }
}
