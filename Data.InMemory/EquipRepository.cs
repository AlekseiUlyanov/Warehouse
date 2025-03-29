using Data.Entities;

namespace Data.InMemory
{
    public class EquipRepository : IEquipRepository
    {
        private readonly List<Equip> _dataSource = new();

        public void Add(Equip equip)
        {
            //equip.Id = Guid.NewGuid();
            _dataSource.Add(equip);
        }

        public Equip Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equip> GetAll()
        {
            foreach (var equip in _dataSource)
                yield return equip; //изучить
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
