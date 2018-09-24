using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTest
{
    class Test
    {
        public int alder;

        public Test(int alder)
        {
            this.alder = alder;
        }

        public override string ToString()
        {
            return "Alder:" + alder; 
        } 
    }
}
