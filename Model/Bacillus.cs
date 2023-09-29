using Petri_Life.Enum;

namespace Petri_Life.Model
    {
    public class Bacillus : BaseBacteria
    {
        public Bacillus(int positionX, int positionY, BacteriaTypes bacteriaType) : base(positionX, positionY, bacteriaType)
        {
            LifeSpan = 10;
            Nearby = 3;
        }
        public override BaseBacteria Split()
        {
            return new Bacillus(PositionX, PositionY, BacteriaType)
            {
                LifeSpan = this.LifeSpan,
                Nearby = this.Nearby
            };
        }
        public override string ToString()
        {
            return "B";
        }
    }
}
