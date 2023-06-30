using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Storage
{
    public class PollStorage
    {
        private const string StoragePath = "../../../Data/Polls.json";

        private Serializer<Poll> _serializer;


        public PollStorage()
        {
            _serializer = new Serializer<Poll>();
        }

        public List<Poll> Load()
        {
            return _serializer.FromJSON(StoragePath);
        }

        public void Save(List<Poll> polls)
        {
            _serializer.ToJSON(StoragePath, polls);
        }
    }
}
