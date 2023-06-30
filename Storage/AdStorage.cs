using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Storage
{
    public class AdStorage
    {
        private const string StoragePath = "../../../Data/Ads.json";

        private Serializer<Ad> _serializer;


        public AdStorage()
        {
            _serializer = new Serializer<Ad>();
        }

        public List<Ad> Load()
        {
            return _serializer.FromJSON(StoragePath);
        }

        public void Save(List<Ad> ads)
        {
            _serializer.ToJSON(StoragePath, ads);
        }
    }
}
