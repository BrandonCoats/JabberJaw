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
        //allright big stuff here make a foreign key in the new table cal UserVAlues and use the user name from the session to do a query in here to access it .
       //nevermiond get directly from user
       public IList<UserValue> getValueForUser(string email)
        {
            var userData = context.AspNetUsers.Select(x => x).ToList().Select(

                VFU =>
                new UserValue
                {

                    UserVal = (int)VFU.Value,
                   Email = VFU.Email
                    // id = VFU.Id,
                    //Email = VFU.Email,
                    //EmailConfirmed = VFU.EmailConfirmed,
                    //PasswordHash = VFU.PasswordHash,
                    //SecurityStamp = VFU.SecurityStamp,
                    //PhoneNumber = VFU.PhoneNumber,
                    //PhoneNumberConfirmed = VFU.PhoneNumberConfirmed,
                    //TwoFactorEnabled = VFU.TwoFactorEnabled,
                    //LockoutEndDateUTC = (DateTime)VFU.LockoutEndDateUtc,
                    //LockoutEnabled = VFU.LockoutEnabled,
                    //AccessFailedCount = VFU.AccessFailedCount,
                    //UserName = VFU.UserName,
                    //Value = (int)VFU.Value
                }
                );
            Console.WriteLine(userData);
            var valueForUser =
           from r in userData
           where r.Email.Equals(email)
           select r;
            //gives back all the responses where input matches
            if(valueForUser == null)
            {
                return null;
            }
            return valueForUser.ToList();
         
        }
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

        public void addRow(JabberJawData.LearningData data)
        {

            //data.input = "shit is broke";
            context.LearningDatas.Add(data);
            //context.Database.ExecuteSqlCommand("insert into LearningData(response,input,value)"+ 
            //    "Values('"+data.response+"','"+data.input+"',"+data.value+")");
            context.SaveChanges();
        }
    }

}