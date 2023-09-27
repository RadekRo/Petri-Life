using Petri_Life.Enum;

namespace Petri_Life.Model
{
    public class Coccus : BaseBacteria
    {
        public Coccus(int positionX, int positionY, BacteriaTypes bacteriaType) : base(positionX, positionY, bacteriaType)
        {
            int initiallifespan = InitialLifeSpan;
            int lifespan = LifeSpan;
            int nearby = Nearby;
            int x = positionX;
            int y = positionY;

            InitialLifeSpan = 100;
            LifeSpan = 100;
            Nearby = 1;
        }
        public override string ToString()
        {
            return "C";
        }
    }
}