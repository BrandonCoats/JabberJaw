using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammer
{
    class Sentence : Grammer
    {
        NounPhrase nounPhrase;
        VerbPhrase verbPhrase;

    public NounPhrase getNounPhrase()
    {
        return nounPhrase;
    }
    public void setNounPhrase(NounPhrase nounPhrase)
    {
        this.nounPhrase = nounPhrase;
    }
    public VerbPhrase getVerbPhrase()
    {
        return verbPhrase;
    }
    public void setVerbPhrase(VerbPhrase verbPhrase)
    {
        this.verbPhrase = verbPhrase;
    }

        public override string printSelf()
        {
            throw new NotImplementedException();
        }
    }
}
