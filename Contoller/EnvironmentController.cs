using Petri_Life.DAO;
using Petri_Life.Model;
using Petri_Life.Utils;

namespace Petri_Life.Contoller
{
    public class EnvironmentController
    {
        TimePulse tp = new TimePulse();
        BacteriaDAO bDAO = new BacteriaDAO();
        public void InititateTimePulse(List<BaseBacteria> bacteriasList)
        {
            List<BaseBacteria> bacteriesToVanish = new List<BaseBacteria>();
            foreach (BaseBacteria bacteria in bacteriasList)
            {

                if (tp.IsAbletoSplit(bacteria))
                {
                    Console.WriteLine($"{bacteria.BacteriaType.ToString()} has splitted!");
                    bacteriesToVanish.Add(bacteria);
                }
            }

            foreach (BaseBacteria bacteria in bacteriesToVanish)
            {
                bDAO.Delete(bacteriasList, bacteria);
            }
           
        }
        public void DecreaseBacteriasLife(List<BaseBacteria> bacteriasList)
        {
            foreach (BaseBacteria bacteria in bacteriasList)
            {
                bDAO.ReduceLife(bacteria);
            }
        }
    }
}
