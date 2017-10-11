using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JabberJaw.Models
{
    public class Learning
    {

        public int id { get; set; }
        public string word { get; set; }
        public string partOfSpeech { get; set; }
        public string respondedTo { get; set; }
    }
}