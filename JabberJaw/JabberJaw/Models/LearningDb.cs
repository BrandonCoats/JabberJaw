using JabberJawData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JabberJaw.Models
{
    public class LearningDb 
    {
        LearningDbEntities context = new LearningDbEntities();

        public IList<LearningData> getAllData()
        {
            var feedback = context.LearningDatas.Select(x => x).ToList().Select(

                ld =>
                new LearningData
                {
                    id = ld.id,
                    word = ld.word,
                    partOfSpeech = ld.partOfSpeech,
                    respondedTo = ld.responedTo
                }
                );
            return feedback.ToList();
        }
    }

}