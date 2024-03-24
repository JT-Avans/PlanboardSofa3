using Core.Domain.Analysis;
using Core.Domain.Planboard;
using Moq;

namespace UnitTests;

public class AnalysisTests
{
    [Fact]
    public void ReportConstructor_ShouldInitializePropertiesCorrectly()
    {
        var mockExport = new Mock<IExport>();
        var report = new Report("header", "footer", mockExport.Object);

        Assert.Equal("header", report.Header);
        Assert.Equal("footer", report.Footer);
        Assert.Equal(mockExport.Object, report.Content);
    }
    
    [Fact]
    public void JsonExport_VisitBugTicket_ShouldWriteExportMessageToConsole()
    {
        var jsonExport = new JsonExport();
        var bugTicket = new BugTicket(123, "description", "reporter", 123, 123);
        using StringWriter consoleOutput = new();
        Console.SetOut(consoleOutput);

        jsonExport.visitBugTicket(bugTicket);

        Assert.Equal("Export BugTickets to JSON\r\n", consoleOutput.ToString());
        
        // Reset the console output
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
    }

    [Fact]
    public void JsonExport_VisitTaskTicket_ShouldWriteExportMessageToConsole()
    {
        var jsonExport = new JsonExport();
        var taskTicket = new TaskTicket(123, "title", "title", 123);
        using StringWriter consoleOutput = new();
        Console.SetOut(consoleOutput);

        jsonExport.visitTaskTicket(taskTicket);
        // Reset the console output
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        
        Assert.Equal("Export BugTickets to CSV\r\n", consoleOutput.ToString());
        

    }
    
    [Fact]
    public void VisitTaskTicket_ShouldInvokeCorrectMethodOnExport()
    {
        var mockExport = new Mock<IExport>();
        var taskTicket = new TaskTicket(123, "title", "title", 123);

        mockExport.Object.visitTaskTicket(taskTicket);

        mockExport.Verify(e => e.visitTaskTicket(taskTicket), Times.Once);
    }

    [Fact]
    public void VisitBugTicket_ShouldInvokeCorrectMethodOnExport()
    {
        var mockExport = new Mock<IExport>();
        var bugTicket = new BugTicket(123, "description", "reporter", 123, 123);

        mockExport.Object.visitBugTicket(bugTicket);

        mockExport.Verify(e => e.visitBugTicket(bugTicket), Times.Once);
    }
    
    [Fact]
    public void VisitBugTicket_ShouldWriteExportMessageToConsole()
    {
        var csvExport = new CsvExport();
        var bugTicket = new BugTicket(123, "description", "reporter", 123, 123);
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        csvExport.visitBugTicket(bugTicket);

        Assert.Equal("Export BugTickets to CSV\r\n", consoleOutput.ToString());
            
        // Reset the console output
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
    }

    [Fact]
    public void VisitTaskTicket_ShouldWriteExportMessageToConsole()
    {
        var csvExport = new CsvExport();
        var taskTicket = new TaskTicket(123, "title", "title", 123);
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        csvExport.visitTaskTicket(taskTicket);

        Assert.Equal("Export TaskTicket to CSV\r\n", consoleOutput.ToString());
        
        // Reset the console output
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
    }
}