using Petri_Life.Contoller;
using Petri_Life.Data;
using Petri_Life.Model;
using Petri_Life.Utils;
using Petri_Life.View;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Petri_Life
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitialSetup initSetup = new InitialSetup();
            EnvironmentController envctr = new EnvironmentController();
            int LifeCycle = 1;
            Display display = new Display(25, 25);
            List<BaseBacteria> livingBacteriasList = new List<BaseBacteria>();
            
            initSetup.InitialData(livingBacteriasList);

            while (true)
            {
                display.ClearDish();
                display.PlaceBacterias(livingBacteriasList);
                display.DisplayCurrentDish();
                Console.WriteLine($"Current LifeCycle: {LifeCycle}");

                envctr.InititateTimePulse(livingBacteriasList);
                envctr.DecreaseBacteriasLife(livingBacteriasList);
                
                var pressedKey = Console.ReadKey().Key;
                if (pressedKey == ConsoleKey.Spacebar)
                {
                    break;
                }
                LifeCycle++;
            }

        }
    }
}