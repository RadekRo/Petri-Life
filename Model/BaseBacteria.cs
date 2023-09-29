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

        public BaseBacteria Split()
        {
            BaseBacteria newInstance =  new (1, 5, BacteriaType);
            return newInstance;
        }

        public override string ToString()
        {
            return $"I am: {BacteriaType.ToString()}. I have lifespan: {this.LifeSpan} and I am positioned at: X({PositionX}), Y({PositionY}) and my Nearby range is: {Nearby}";
        }

        //public BaseBacteria DeepCopy()
        //{
        //    BaseBacteria other = (BaseBacteria)this.MemberwiseClone();
        //    other.LifeSpan = this.InitialLifeSpan;
        //    return other;
        //}
    }
}

