using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Storage
{
    public class GuideStorage
    {
        private const string StoragePath = "../Data/Guide.json";

        private Serializer<Guide> _serializer;


        public GuideStorage()
        {
            _serializer = new Serializer<Guide>();
        }

        public List<Guide> Load()
        {
            return _serializer.FromJSON(StoragePath);
        }

        public void Save(List<Guide> guides)
        {
            _serializer.ToJSON(StoragePath, guides);
        }
    }
}
