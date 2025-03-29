using UI.WinForms.Data;

namespace UI.WinForms.Business
{
    class BusinessLayerEquipManager : IBusinessLayer
    {
        public void GenerateId(Equip equip)
        {
            equip.Id = Guid.NewGuid();
        }
    }
}
