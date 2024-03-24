using Core.Domain.Planboard;

namespace Core.Domain.Observer;

public class TicketObserver
{
    readonly Observable observable;

    public TicketObserver(Observable observable)
    {
        this.observable = observable;
    }

    public void Subscribe(IObserver observer)
    {
        observable.Attach(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observable.Detach(observer);
    }
    
    public static void Update(ITicket ticket)
    {
        Console.WriteLine($"Ticket updated: {ticket.Title}");
    }
}