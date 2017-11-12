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
                    response = ld.response,
                    input = ld.input,
                    value = (int)ld.value
                }
                );
            return feedback.ToList();
        }
        public IList<LearningData> getAllResponsesForInput(string input)
        {
            var feedback = context.LearningDatas.Select(x => x).ToList().Select(

               ld =>
               new LearningData
               {
                   id = ld.id,
                   response = ld.response,
                   input = ld.input,
                   value = (int)ld.value
               }
               );
            var responsesForInput =
           from r in feedback
           where r.input.Equals(input)
           select r;
          //gives back all the responses where input matches
            return responsesForInput.ToList();
        }
        public IList<LearningData> getInput(string input)
        {
            var feedback = context.LearningDatas.Select(x => x).ToList().Select(

               ld =>
               new LearningData
               {
                   id = ld.id,
                   response = ld.response,
                   input = ld.input,
                   value = (int)ld.value
               }
               );
            var respondedTo =
           from r in feedback
           where r.input.Equals(input)
           select r;

            return respondedTo.ToList();
        }
     
        public IList<LearningData> getByWord(string word)
        {
            var feedback = context.LearningDatas.Select(x => x).ToList().Select(

               ld =>
               new LearningData
               {
                   id = ld.id,
                   response = ld.response,
                   input = ld.input,
                   value = (int)ld.value
               }
               );
            var entryForWord =
           from r in feedback
           where r.input.Contains(word)
           select r;

            return entryForWord.ToList();
        }
    }

}