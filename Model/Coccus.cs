namespace Petri_Life.Model
{
    public class Coccus : BaseBacteria
    {
        public Coccus(int positionX, int positionY) : base(positionX, positionY)
        {
            int lifespan = LifeSpan;
            int nearby = Nearby;
            int x = positionX;
            int y = positionY;

            LifeSpan = 100;
            Nearby = 1;
        }
    }
}