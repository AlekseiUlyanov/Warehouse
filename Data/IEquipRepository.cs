using Data.Entities;

namespace Data
{
    public interface IEquipRepository
    {
        void Add(Equip equip);
        void Remove(int id);
        Equip Find(int id);
        IEnumerable<Equip> GetAll();
    }
}
