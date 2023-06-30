using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{
    public class Poll
    {
        public string Id { get; set; }
        public string QuestionsId { get; set; }
        public List<int> Answers { get; set; }
        public string ForeignId { get; set; } //this can be linked to guide, tourist or tour
        public string RecommendationsForImprovement { get; set; }

        public Poll() { }
        public Poll(string id, string questionsId, List<int> answers, string foreignId, string recomendations) 
        {
            Id = id;
            QuestionsId = questionsId;
            Answers = answers;
            ForeignId = foreignId;
            RecommendationsForImprovement = recomendations;
        }

    }
}
