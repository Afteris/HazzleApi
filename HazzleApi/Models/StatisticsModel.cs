using System;
using System.Collections.Generic;


namespace HazzleApi.Models
{
    
    public class StatisticsModel
    {
        public string id { get; set; }
        public string path { get; set; }
        public string title { get; set; }
        public double score { get; set; }
        public DateTime published { get; set; }
    }

    public class StatisticsModelRoot
    {
        public List<StatisticsModel> MyArray { get; set; }
    }
}
