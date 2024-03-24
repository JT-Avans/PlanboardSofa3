using Core.Domain.Planboard;

namespace Core.Domain.Observer;

public interface IObserver
{
    void Update(ITicket ticket);
}