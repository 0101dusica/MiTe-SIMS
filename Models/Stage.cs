using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{
    public class Stage
    {
        public string AtractionId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int PlannedBudget { get; set; }
        public Stage() { }
        public Stage(string atractionId, TimeOnly startTime, TimeOnly endTime, int plannedBudget) 
        {
            AtractionId = atractionId;
            StartTime = startTime;
            EndTime = endTime;
            PlannedBudget = plannedBudget;
        }
    }
}
