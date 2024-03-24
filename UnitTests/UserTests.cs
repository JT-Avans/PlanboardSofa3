using Core.Domain;

namespace UnitTests
{
    public class UserTests
    {
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int expectedId = 1;
            string expectedName = "Test User";

            // Act
            var user = new User(expectedId, expectedName);

            // Assert
            Assert.Equal(expectedId, user.ID);
            Assert.Equal(expectedName, user.Name);
        }
    }
}