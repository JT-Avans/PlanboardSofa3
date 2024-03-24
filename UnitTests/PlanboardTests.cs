using Core.Domain;
using Core.Domain.Analysis;
using Core.Domain.Observer;
using Core.Domain.Planboard;

using Moq;

namespace UnitTests
{
    public class PlanboardTests
    {
        [Fact]
        public void AddColumns_ShouldAddNewColumnToList()
        {
            var planBoard = new PlanBoard();
            var column = new Column("NewColumn");

            planBoard.addColumns(column);

            Assert.Contains(column, planBoard.Columns);
        }

        [Fact]
        public void RemoveColumns_ShouldRemoveExistingColumnFromList()
        {
            var planBoard = new PlanBoard();
            var column = new Column("NewColumn");
            planBoard.addColumns(column);

            planBoard.removeColumns(column);

            Assert.DoesNotContain(column, planBoard.Columns);
        }

        [Fact]
        public void MoveColumn_ShouldChangeColumnPositionInList()
        {
            var planBoard = new PlanBoard();
            var column = new Column("NewColumn");
            planBoard.addColumns(column);
            int oldIndex = planBoard.Columns.IndexOf(column);

            planBoard.MoveColumn(column, 0);

            int newIndex = planBoard.Columns.IndexOf(column);
            Assert.NotEqual(oldIndex, newIndex);
        }

        [Fact]
        public void MoveColumn_ShouldThrowException_WhenNewIndexIsOutOfRange()
        {
            var planBoard = new PlanBoard();
            var column = new Column("NewColumn");
            planBoard.addColumns(column);

            Assert.Throws<ArgumentOutOfRangeException>(() => planBoard.MoveColumn(column, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => planBoard.MoveColumn(column, planBoard.Columns.Count + 1));
        }
        
        [Fact]
        public void AddTicket_ShouldAddTicketToColumn()
        {
            var column = new Column("Column1");
            var mockTicket = new Mock<ITicket>();

            column.addTicket(mockTicket.Object);

            Assert.Contains(mockTicket.Object, column.Tickets);
        }

        [Fact]
        public void RemoveTicket_ShouldRemoveTicketFromColumn()
        {
            var column = new Column("Column1");
            var mockTicket = new Mock<ITicket>();
            column.addTicket(mockTicket.Object);

            column.removeTicket(mockTicket.Object);

            Assert.DoesNotContain(mockTicket.Object, column.Tickets);
        }

        [Fact]
        public void RemoveTicket_ShouldNotThrowException_WhenTicketNotInColumn()
        {
            var column = new Column("Column1");
            var mockTicket = new Mock<ITicket>();

            var exception = Record.Exception(() => column.removeTicket(mockTicket.Object));

            Assert.Null(exception);
        }
        
        [Fact]
        public void UpdateSeverity_ShouldUpdateSeverityProperty()
        {
            var bugTicket = new BugTicket(1, "Title", "Description", 1, 1);

            bugTicket.updateSeverity(2);

            Assert.Equal(2, bugTicket.Severity);
        }

        [Fact]
        public void AddTicketActivity_ShouldAddActivityToTicketActivitiesList()
        {
            var bugTicket = new BugTicket(1, "Title", "Description", 1, 1);
            var ticketActivity = new TicketActivity(1, "Title", "Description");

            bugTicket.addTicketActivity(ticketActivity);

            Assert.Contains(ticketActivity, bugTicket.TicketActivities);
        }

        [Fact]
        public void MarkAsCompleted_ShouldSetIsCompletedToTrue()
        {
            var bugTicket = new BugTicket(1, "Title", "Description", 1, 1);

            bugTicket.MarkAsCompleted();

            Assert.True(bugTicket.IsCompleted);
        }
        
        [Fact]
public void Accept_ShouldInvokeCorrectMethodOnExport()
{
    var mockExport = new Mock<IExport>();
    var taskTicket = new TaskTicket(1, "title", "description", 1);

    taskTicket.accept(mockExport.Object);

    mockExport.Verify(e => e.visitTaskTicket(taskTicket), Times.Once);
}
    }
}