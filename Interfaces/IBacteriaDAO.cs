using Petri_Life.Enum;
using Petri_Life.Model;

namespace Petri_Life.Interfaces
{
    public interface IBacteriaDAO
    {
        void CreateBacteria(BacteriaTypes type);
        void AddBacteria(List<BaseBacteria> bacteriaList, BaseBacteria bacteria);
        void UpdateBacteria(BaseBacteria bacteria);
        void DeleteBacteria(List<BaseBacteria> bacteriaList, BaseBacteria bacteria);
        void SplitBacteria(List<BaseBacteria> bacteriaList, BaseBacteria bacteria);   
    }
}
