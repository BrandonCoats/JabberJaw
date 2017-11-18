using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JabberJaw.Models
{
    public class UseWords
    {
        public UseWords(string word, string partOfspeech)
        {
            this.word = word;
            this.partOfspeech = partOfspeech;
        }
        public string word { get; set; }
        public string partOfspeech { get; set; }
    }
}