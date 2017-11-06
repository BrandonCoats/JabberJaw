using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JabberJaw.Models
{
    public class DatabaseRetrieval
    {
        public IList<LearningData> AllFeedback { get; set; }
        public IList<LearningData> AllWithPartOfSpeech { get; set; }
        public IList<LearningData> AllThatResponded { get; set; }
        public IList<LearningData> GetById { get; set; }
        public IList<LearningData> GetByWord { get; set; }
        public IList<string> GetSentence { get; set; }

    }
}