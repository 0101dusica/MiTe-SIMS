using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Storage
{
    public class TouristStorage
    {
        private const string StoragePath = "../Data/Tourist.json";

        private Serializer<Tourist> _serializer;


        public TouristStorage()
        {
            _serializer = new Serializer<Tourist>();
        }

        public List<Tourist> Load()
        {
            return _serializer.FromJSON(StoragePath);
        }

        public void Save(List<Tourist> tourists)
        {
            _serializer.ToJSON(StoragePath, tourists);
        }
    }
}
