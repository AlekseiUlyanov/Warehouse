using Application.Equips.Dto;
using Data;
using Data.Entities;

namespace Application.Equips.Services
{
    public class EquipService : IEquipService
    {
        private readonly IEquipRepository _equipRepository;

        public EquipService(IEquipRepository equipRepository)
        {
            _equipRepository = equipRepository;
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

            _equipRepository.Add(equip);
        }

        public IEnumerable<EquipDto> GetAll()
        {
            foreach (var equip in _equipRepository.GetAll())
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
