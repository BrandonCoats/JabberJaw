using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammer
{
    class Noun : Grammer
    {
        String noun;

    public Noun(String noun)
    {
        
        this.noun = noun;
    }

    public String getNoun()
    {
        return noun;
    }

        public override string printSelf()
        {
            return noun;
        }

        public void setNoun(String noun)
    {
        this.noun = noun;
    }
   

}
}
