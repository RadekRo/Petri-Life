using Petri_Life.DAO;
using Petri_Life.Model;
using Petri_Life.Utils;
using System;

namespace Petri_Life.Contoller
{
    public class EnvironmentController
    {
        TimePulse tp = new TimePulse();
        BacteriaDAO bDAO = new BacteriaDAO();

        public void InititateTimePulse(List<BaseBacteria> bacteriasList)
        {
            List<BaseBacteria> bacteriesToRemove = new List<BaseBacteria>();
            List<BaseBacteria> bacteriesToAdd = new List<BaseBacteria>();
            foreach (BaseBacteria bacteria in bacteriasList)
            {

                if (tp.IsAbletoSplit(bacteria))
                {
                    BaseBacteria newBacteria = bacteria.Split();
                    newBacteria.PositionX = 1;
                    newBacteria.PositionY = 1;
                    Console.WriteLine(newBacteria);
                    bacteriesToRemove.Add(bacteria);
                    bacteriesToAdd.Add(newBacteria);
                }
            }

            foreach (BaseBacteria bacteria in bacteriesToRemove)
            {
                bDAO.Delete(bacteriasList, bacteria);
            }
            foreach (BaseBacteria bacteria in bacteriesToAdd)
            {
                bacteriasList.Add(bacteria);
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
