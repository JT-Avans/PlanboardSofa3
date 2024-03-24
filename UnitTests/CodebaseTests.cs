using Core.Domain.Codebase;
using Moq;

namespace UnitTests
{
    public class CodebaseTests
    {
        [Fact]
        public void SourceCode_ShouldCallAuthenticateGetSourceCodeAndFormatSourceCode()
        {
            var mockGitConnector = new Mock<GitConnector> { CallBase = true };

            mockGitConnector.Object.SourceCode();

            mockGitConnector.Verify(m => m.authenticate(), Times.Once);
            mockGitConnector.Verify(m => m.getSourceCode(), Times.Once);
            mockGitConnector.Verify(m => m.formatSourceCode(), Times.Once);
        }
        
        [Fact]
        public void Authenticate_ShouldWriteAuthenticateToGithubToConsole()
        {
            var githubConnector = new GithubConnector();
            using StringWriter consoleOutput = new();
            Console.SetOut(consoleOutput);

            githubConnector.authenticate();

            Assert.Equal("Authenticate to Github\r\n", consoleOutput.ToString());
            
            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }

        [Fact]
        public void GetSourceCode_ShouldWriteGetSourceCodeGithubToConsole()
        {
            var githubConnector = new GithubConnector();
            using StringWriter consoleOutput = new();
            Console.SetOut(consoleOutput);

            githubConnector.getSourceCode();

            Assert.Equal("GetSourceCode Github\r\n", consoleOutput.ToString());
            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }

        [Fact]
        public void FormatSourceCode_ShouldWriteFormatSourceCodeGithubToConsole()
        {
            var githubConnector = new GithubConnector();
            using StringWriter consoleOutput = new();
            Console.SetOut(consoleOutput);

            githubConnector.formatSourceCode();

            Assert.Equal("Format sourceCode Github\r\n", consoleOutput.ToString());
            
            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }
        
        [Fact]
        public void Authenticate_ShouldWriteAuthenticateToGitlabToConsole()
        {
            var gitlabConnector = new GitlabConnecter();
            using StringWriter consoleOutput = new();
            Console.SetOut(consoleOutput);

            gitlabConnector.authenticate();

            
            Assert.Equal("Authenticate to Gitlab\r\n", consoleOutput.ToString());
            
            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }

        [Fact]
        public void GetSourceCode_ShouldWriteGetSourceCodeGitlabToConsole()
        {
            var gitlabConnector = new GitlabConnecter();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            gitlabConnector.getSourceCode();

            Assert.Equal("GetSourceCode Gitlab\r\n", consoleOutput.ToString());
            
            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }

        [Fact]
        public void FormatSourceCode_ShouldWriteFormatSourceCodeGitlabToConsole()
        {
            var gitlabConnector = new GitlabConnecter();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            gitlabConnector.formatSourceCode();

            Assert.Equal("Format sourceCode Gitlab\r\n", consoleOutput.ToString());
            
            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }
    }
}