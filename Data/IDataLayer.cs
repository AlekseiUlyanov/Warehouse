using Data.Entities;

namespace Data
{
    public interface IDataLayer
    {
        void Add(Equip equip);
        void Remove(int Id);
        Equip Find(int Id);
        IEnumerable<Equip> GetAll();
    }
}
