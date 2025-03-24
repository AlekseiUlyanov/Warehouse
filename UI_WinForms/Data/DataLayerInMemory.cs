namespace UI_WinForms.Data
{
    public class DataLayerInMemory : IDataLayer
    {
        private readonly List<Equip> dataSource = new();

        public void Add(Equip equip)
        {
            //equip.Id = Guid.NewGuid();
            dataSource.Add(equip);
        }

        public Equip Find(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equip> GetAll()
        {
            foreach (var d in dataSource)
                yield return d; //изучить
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
