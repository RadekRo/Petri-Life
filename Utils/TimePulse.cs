using Petri_Life.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Petri_Life.Utils
{
    public class TimePulse
    {
        public TimePulse() { }
        public bool IsAbletoSplit(BaseBacteria bacteria)
        {
            return bacteria.LifeSpan == 0;
        }
        public bool IsAlive(List<BaseBacteria> bacteriasList, BaseBacteria bacteria)
        {
            return true;
        }

    }
}
