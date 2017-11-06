using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammer
{
    class Verb : Grammer
    {
        String verb;

public String getVerb()
    {
        return verb;
    }

    public void setVerb(String verb)
    {
        this.verb = verb;
    }

        public override string printSelf()
        {
            return verb;
        }

        public Verb(String verb)
    {
       
        this.verb = verb;
    }

  

}
}
