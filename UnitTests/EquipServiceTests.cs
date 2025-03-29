using Application.Equips.Dto;
using Application.Equips.Services;
using Data;
using Moq;

namespace UnitTests
{
    public class EquipServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BusinessExceptionTest()
        {
            // Arrange
            var mock = new Mock<IEquipRepository>();

            IEquipService equipService = new EquipService(mock.Object);
            EquipDto equipDto = new();

            // Assert
            Assert.Throws<ApplicationException>(
                    // Action
                    () => equipService.Create(equipDto)
                );
        }
    }
}
