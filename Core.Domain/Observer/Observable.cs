using Core.Domain.Planboard;

namespace Core.Domain.Observer;

public class Observable
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(ITicket ticket)
    {
        foreach (var observer in observers)
        {
            observer.Update(ticket);
        }
    }
}