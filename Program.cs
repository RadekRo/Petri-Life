using Petri_Life.Data;
using Petri_Life.Model;

namespace Petri_Life
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitialSetup initialSetup = new InitialSetup();
            List<BaseBacteria> livingBacteriasList = new List<BaseBacteria>();
            initialSetup.InitialData(livingBacteriasList);
            Console.WriteLine(livingBacteriasList[0]);

        }
    }
}