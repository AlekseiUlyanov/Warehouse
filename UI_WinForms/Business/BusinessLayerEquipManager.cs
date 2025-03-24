using UI_WinForms.Data;

namespace UI_WinForms.Business
{
    class BusinessLayerEquipManager : IBusinessLayer
    {
        public void GenerateId(Equip equip)
        {
            equip.Id = Guid.NewGuid();
        }
    }
}
