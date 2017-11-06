using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammer
{
    class NounPhrase : Grammer
    {
        Article atricle;
        Noun noun;
        Preposition prep;
public Preposition getPrep()
    {
        return prep;
    }
    public void setPrep(Preposition prep)
    {
        this.prep = prep;
    }
    public Article getAtricle()
    {
        return atricle;
    }
    public void setAtricle(Article atricle)
    {
        this.atricle = atricle;
    }
    public Noun getNoun()
    {
        return noun;
    }
    public void setNoun(Noun noun)
    {
        this.noun = noun;
    }

        public override string printSelf()
        {
            return noun.getNoun();
        }
    }

}
