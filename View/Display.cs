using Petri_Life.Model;
using System.ComponentModel.DataAnnotations;

namespace Petri_Life.View
{
    public class Display
    {
        public int Width;
        public int Height;
        string[,] Dish;


        public Display(int width, int height) 
        { 
            Width = width;
            Height = height;
            Dish = new string[width, height];
        }

        public void ClearDish()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Dish[i, j] = "_";
                }
            }
        }
        public void DisplayCurrentDish()
        {
            Console.Clear();

            for (int i = 0; i < Width; i++) 
            { 
                for (int j = 0; j < Height; j++) 
                {
                    Console.Write(Dish[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void PlaceBacterias(List<BaseBacteria> bacteriasList)
        {
            foreach (BaseBacteria bacteria in bacteriasList)
            {
                Dish[bacteria.PositionX - 1, bacteria.PositionY - 1] = bacteria.ToString();
            }
        }
    }
}
