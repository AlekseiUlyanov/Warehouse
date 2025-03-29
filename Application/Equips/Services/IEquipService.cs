using Application.Equips.Dto;

namespace Application.Equips.Services
{
    public interface IEquipService
    {
        void Create(EquipDto equipDto);

        IEnumerable<EquipDto> GetAll();
    }

}
