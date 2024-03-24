using Core.Domain.Planboard;

namespace Core.Domain.Observer;

public class Observer : IObserver
{
    public void Update(ITicket ticket)
    {
        Console.WriteLine($"Ticket updated: {ticket.Title}");
    }
}