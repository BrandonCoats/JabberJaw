using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammer
{
    class Article : Grammer
    {

        String art;

public Article(String art)
    {
        this.art = art;
    }

    public String getArt()
    {
        return art;
    }

    public void setArt(String art)
    {
        this.art = art;
    }
        public override string printSelf()
        {
            return art;
        }
    }
}
