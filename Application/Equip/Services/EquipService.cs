using Data;

namespace Application.Equip.Services
{
    public class EquipService : IEquipService
    {
        private readonly IDataLayer _dataLayer;

        public EquipService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }
    }
}
