namespace Core.Domain.Observer;

public class TicketObserver
{
    private Observable observable;

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
}