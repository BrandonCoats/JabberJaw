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
                    word = ld.,
                    partOfSpeech = ld.partOfSpeech,
                    respondedTo = ld.responedTo
                }
                );
            return feedback.ToList();
        }
        public IList<LearningData> getAllbyPartOfSpeech(String pOfS)
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
            var JustThePartOfSpeech =
           from r in feedback
           where r.partOfSpeech.Equals(pOfS)
           select r;
          
            return JustThePartOfSpeech.ToList();
        }
        public IList<LearningData> getAllRespondingTo(String respondString)
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
            var respondedTo =
           from r in feedback
           where r.respondedTo.Equals(respondString)
           select r;

            return respondedTo.ToList();
        }
        public IList<LearningData> getDataById(int id)
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
            var wordById =
           from r in feedback
           where r.id == id
           select r;

            return wordById.ToList();
        }
        public IList<LearningData> getByWord(String word)
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
            var entryForWord =
           from r in feedback
           where r.word.Equals(word)
           select r;

            return entryForWord.ToList();
        }
    }

}