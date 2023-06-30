using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Storage
{
    public class AtractionStorage
    {
        private const string StoragePath = "../../../Data/Atractions.json";

        private Serializer<Atraction> _serializer;


        public AtractionStorage()
        {
            _serializer = new Serializer<Atraction>();
        }

        public List<Atraction> Load()
        {
            return _serializer.FromJSON(StoragePath);
        }

        public void Save(List<Atraction> atractions)
        {
            _serializer.ToJSON(StoragePath, atractions);
        }
    }
}
