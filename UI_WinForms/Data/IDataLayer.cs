namespace UI_WinForms.Data
{
    interface IDataLayer
    {
        void Add(Equip equip);
        void Remove(int Id);
        Equip Find(int Id);
        IEnumerable<Equip> GetAll();
    }
}
