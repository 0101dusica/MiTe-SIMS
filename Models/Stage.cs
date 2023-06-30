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
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PlannedBudget { get; set; }
        public Stage() { }
        public Stage(string atractionId, DateTime startTime, DateTime endTime, int plannedBudget) 
        {
            AtractionId = atractionId;
            StartTime = startTime;
            EndTime = endTime;
            PlannedBudget = plannedBudget;
        }
    }
}
