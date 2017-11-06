using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammer
{
    class Preposition : Grammer
    {

        String prep;
        NounPhrase phrase;

    public NounPhrase getPhrase()
    {
        return phrase;
    }
    public void setPhrase(NounPhrase phrase)
    {
        this.phrase = phrase;
    }
    public String getPrep()
    {
        return prep;
    }
    public void setPrep(String prep)
    {
        this.prep = prep;
    }

        public override string printSelf()
        {
            return prep;
        }
    }

}
