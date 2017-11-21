using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JabberJaw.Models
{
    public class SearchDetails
    {
        public IList<Search> AllText { get; set; }
        public string newText{ get; set; }
        public string feedbackText { get; set; }
        public string previousText { get; set; }
        public string inputString { get; set; }
        public string userNum { get; set; }
    }
}