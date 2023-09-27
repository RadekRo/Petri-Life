using Petri_Life.Enum;
using Petri_Life.Interfaces;
using Petri_Life.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri_Life.DAO
{
    public class BacteriaDAO : IBacteriaDAO
    {
        public void Add(List<BaseBacteria> bacteriaList, BaseBacteria bacteria)
        {
            throw new NotImplementedException();
        }

        public void Create(BacteriaTypes type)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<BaseBacteria> bacteriaList, BaseBacteria bacteria)
        {
            bacteriaList.Remove(bacteria);
        }

        public void Split(List<BaseBacteria> bacteriaList, BaseBacteria bacteria)
        {
            throw new NotImplementedException();
        }

        public void ReduceLife(BaseBacteria bacteria)
        {
            bacteria.LifeSpan--;
        }
    }
}
