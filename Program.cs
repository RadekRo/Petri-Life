using Petri_Life.Data;
using Petri_Life.Model;
using System.Security.Cryptography.X509Certificates;

namespace Petri_Life
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            InitialSetup initSetup = new InitialSetup();
            List<BaseBacteria> livingBacteriasList = new List<BaseBacteria>();
            
            initSetup.InitialData(livingBacteriasList);
            Console.WriteLine(livingBacteriasList[0]);
            Console.WriteLine(livingBacteriasList[0].PositionX);
            Console.WriteLine(livingBacteriasList[0].PositionY);
            Console.WriteLine(livingBacteriasList[1]);
            Console.WriteLine(livingBacteriasList.Count);

        }
    }
}