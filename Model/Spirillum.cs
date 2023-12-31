﻿using Petri_Life.Enum;

namespace Petri_Life.Model
{
    public class Spirillum : BaseBacteria
    {
        public Spirillum(int positionX, int positionY, BacteriaTypes bacteriaType) : base(positionX, positionY, bacteriaType)
        {
            int lifespan = LifeSpan;
            int nearby = Nearby;
            int x = positionX;
            int y = positionY;

            LifeSpan = 40;
            Nearby = 2;
        }
        public override string ToString()
        {
            return "S";
        }
    }
}
