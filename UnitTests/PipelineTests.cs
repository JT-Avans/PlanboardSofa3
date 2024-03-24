using Core.Domain;

namespace UnitTests
{
    public class PipelineTests
    {
        [Fact]
        public void DevopPipeline_ShouldWriteToConsole()
        {
            // Arrange
            var pipeline = new Pipeline();
            var expectedOutput = "Retrieve source\r\nInstall packages\r\nBuilding\r\nRun tests\r\nDeploy\r\n";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            pipeline.DevopPipeline();

            // Assert
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }
    }
}
