using DIContainer.Business;
using DIContainer.Repository.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DIContainer.Tests {

    [TestClass]
    public class CharacterManagerTest {

        [TestCategory("UT.DIContainer.Business.CharacterManager")]
        [TestMethod]
        public void GetSkillsForCharacter_Repository_Called() {
            // Arrange
            var mockRepository = new Mock<ICharacterSkillsRepository>();
            var characterManager = new CharacterManager(mockRepository.Object);

            // Act
            characterManager.GetCharacterSkills(4);

            // Assert
            mockRepository.Verify( m => m.GetSkillsForCharacter(It.IsAny<int>()), Times.Once);
        }
    }
}
