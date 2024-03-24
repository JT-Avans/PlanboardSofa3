using Core.Domain;

namespace UnitTests
{
    public class PipelineTests
    {
        [Fact]
        public void DevopPipeline_ShouldPrintExpectedMessages()
        {
            var pipeline = new Pipeline();
            using StringWriter consoleOutput = new();
            Console.SetOut(consoleOutput);

            pipeline.DevopPipeline();

            var expectedOutput = string.Join(Environment.NewLine, "Retrieve source", "Install packages", "Building", "Run tests", "Deploy") + Environment.NewLine;
            Assert.Equal(expectedOutput, consoleOutput.ToString());
            
            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }
        }
    }

