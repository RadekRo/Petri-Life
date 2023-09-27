using Petri_Life.Enum;

namespace Petri_Life.Model
    {
    public class Bacillus : BaseBacteria
    {
        public Bacillus(int positionX, int positionY, BacteriaTypes bacteriaType) : base(positionX, positionY, bacteriaType)
        {
            int lifespan = LifeSpan;
            int nearby = Nearby;
            int x = positionX;
            int y = positionY;

            LifeSpan = 10;
            Nearby = 3;
        }
        public override string ToString()
        {
            return "B";
        }
    }
}
