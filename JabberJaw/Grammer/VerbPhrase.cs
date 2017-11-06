using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammer
{
    class VerbPhrase : Grammer
    {
        Verb verb;
public Verb getVerb()
    {
        return verb;
    }
    public void setVerb(Verb verb)
    {
        this.verb = verb;
    }
    public NounPhrase getNounPhrase()
    {
        return nounPhrase;
    }
    public void setNounPhrase(NounPhrase nounPhrase)
    {
        this.nounPhrase = nounPhrase;
    }

        public override string printSelf()
        {
            return verb.getVerb();
        }

        NounPhrase nounPhrase;
 

}

}
