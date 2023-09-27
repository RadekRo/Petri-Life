namespace Petri_Life.Model
{
    public class BaseBacteria
    {
        public int LifeSpan { get; set; }
        public int Nearby { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public BaseBacteria(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;

        }
    }
}
