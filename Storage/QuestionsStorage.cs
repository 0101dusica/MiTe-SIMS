using MiTe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Storage
{
    public class QuestionsStorage
    {
        private const string StoragePath = "../../../Data/Questions.json";

        private Serializer<Questions> _serializer;


        public QuestionsStorage()
        {
            _serializer = new Serializer<Questions>();
        }

        public List<Questions> Load()
        {
            return _serializer.FromJSON(StoragePath);
        }

        public void Save(List<Questions> questions)
        {
            _serializer.ToJSON(StoragePath, questions);
        }
    }
}
