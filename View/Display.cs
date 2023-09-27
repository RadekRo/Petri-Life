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

        public void DisplayDish(List<BaseBacteria> bacteriasList)
        {
            
        }

    }
}
