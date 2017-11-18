using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JabberJaw.Models
{
    public class SortedResults
    {
        public SortedResults(LearningData data, int count)
        {
            this.count = count;
            this.data = data;
        }
        public int count { get; set; }

        public LearningData data { get; set; }
    }
}