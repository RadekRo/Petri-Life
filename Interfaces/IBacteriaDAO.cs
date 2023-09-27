using Petri_Life.Enum;
using Petri_Life.Model;

namespace Petri_Life.Interfaces
{
    public interface IBacteriaDAO
    {
        void Create(BacteriaTypes type);
        void Add(List<BaseBacteria> bacteriaList, BaseBacteria bacteria);
        void ReduceLife(BaseBacteria bacteria);
        void Delete(List<BaseBacteria> bacteriaList, BaseBacteria bacteria);
        void Split(List<BaseBacteria> bacteriaList, BaseBacteria bacteria);
    }
}
