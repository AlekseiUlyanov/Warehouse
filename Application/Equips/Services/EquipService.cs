using Application.Equips.Dto;
using Data;
using Data.Entities;

namespace Application.Equips.Services
{
    public class EquipService : IEquipService
    {
        private readonly IDataLayer _dataLayer;

        public EquipService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public void Create(EquipDto equipDto)
        {
            if (string.IsNullOrEmpty(equipDto.Serial) ||
                string.IsNullOrEmpty(equipDto.Type) ||
                string.IsNullOrEmpty(equipDto.Model))
            {
                throw new ApplicationException("Необходимо заполнить все поля");
            }

            Equip equip = new()
            {
                Id = Guid.NewGuid(),
                Serial = equipDto.Serial,
                Type = equipDto.Type,
                Model = equipDto.Model
            };

            _dataLayer.Add(equip);
        }

        public IEnumerable<EquipDto> GetAll()
        {
            foreach (var equip in _dataLayer.GetAll())
            {
                EquipDto equipDto = new()
                {
                    Id = equip.Id,
                    Serial = equip.Serial,
                    Type = equip.Type,
                    Model = equip.Model
                };

                yield return equipDto;
            }
        }
    }
}
