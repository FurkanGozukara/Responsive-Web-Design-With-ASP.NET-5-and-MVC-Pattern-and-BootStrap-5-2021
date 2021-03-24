using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class GlobalClasses
{
    public class customGlobalClass
    {
        private int irRank { get; set; }

        public int returnRank()
        {
            return irRank;
        }

        public void setRank(int _irRank)
        {
            irRank = _irRank % 5000;
        }
    }
}

