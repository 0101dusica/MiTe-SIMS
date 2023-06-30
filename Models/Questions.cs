using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{
    public enum QuestionType
    {
        Tourist,
        Tour,
        Guide
    }

    public class Questions
    {
        public string Id { get; set; }
        public List<string> TextQuestions { get; set; }
        public QuestionType Type { get; set; }
        public Questions() { }
        public Questions(List<string> textQuestions, QuestionType type) 
        {
            TextQuestions = textQuestions;
            Type = type;
        }
    }
}
