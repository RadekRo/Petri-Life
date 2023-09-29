using Petri_Life.Enum;
using System;
using System.Runtime;

namespace Petri_Life.Model
{
    public class BaseBacteria
    {
        public int LifeSpan { get; set; }
        public int InitialLifeSpan { get; set; }
        public int Nearby { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public BacteriaTypes BacteriaType { get; set; }
        public BaseBacteria(int positionX, int positionY, BacteriaTypes bacteriaType)
        {
            PositionX = positionX;
            PositionY = positionY;
            BacteriaType = bacteriaType;
        }

        public virtual BaseBacteria Split()
        {
            return new BaseBacteria(PositionX, PositionY, BacteriaType);
        }

        //public BaseBacteria DeepCopy()
        //{
        //    BaseBacteria other = (BaseBacteria)this.MemberwiseClone();
        //    other.LifeSpan = this.InitialLifeSpan;
        //    return other;
        //}
    }
}

