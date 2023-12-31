﻿using Petri_Life.Enum;
using Petri_Life.Model;

namespace Petri_Life.Data
{
    public class InitialSetup
    {
        public void InitialData(List<BaseBacteria> bacteriasList)
        {
            bacteriasList.Add(new Bacillus(3, 5, BacteriaTypes.Bacillus));
            bacteriasList.Add(new Coccus(2, 4, BacteriaTypes.Coccus));
        }
    }
}
