using Core.Domain.Planboard;
using Core.Domain.Forums;

using Moq;
using Thread = Core.Domain.Forums.Thread;

namespace UnitTests
{
    public class ForumTests
    {

        [Fact]
        public void TicketCompletionStatusChanged_ShouldChangeThreadStateToClosed_WhenTicketIsCompleted()
        {
            var mockTicket = new Mock<ITicket>();
            mockTicket.Setup(t => t.MarkAsCompleted()).Returns(true);
            var thread = new Thread(mockTicket.Object);

            thread.TicketCompletionStatusChanged();

            Assert.IsType<ClosedThreadState>(thread.ThreadState);
        }

        [Fact]
        public void TicketCompletionStatusChanged_ShouldChangeThreadStateToOpen_WhenTicketIsNotCompleted()
        {
            var mockTicket = new Mock<ITicket>();
            mockTicket.Setup(t => t.MarkAsCompleted()).Returns(false);
            var thread = new Thread(mockTicket.Object);

            thread.TicketCompletionStatusChanged();

            Assert.IsType<OpenThreadState>(thread.ThreadState);
        }

        [Fact]
        public void AddMessage_ShouldThrowException_WhenMessageIsNull()
        {
            var mockThread = new Mock<Thread>();
            var openThreadState = new OpenThreadState(mockThread.Object);
            Message message = null;

            Assert.Throws<ArgumentNullException>(() => openThreadState.addMessage(message));
        }
    }
}