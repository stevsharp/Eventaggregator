
namespace Eventaggregator;

public sealed class EventAggregator
{
    object _lock = new();
    List<(Type eventType, Delegate method)> registrationList = [];

    public SubScription Subscribe<T>(Action<T> action) where T : class
    {
        if (action is null)
            return new SubScription(() => {
                Console.WriteLine("action is null");
            });

        lock (_lock)
        {
            registrationList.Add((typeof(T), action));

            return new SubScription (() =>
            {
                registrationList.Remove((typeof(T), action));
            });
        }


    }

    public void Publish<T>(T data) where T : class
    {
        List<(Type eventType, Delegate method)>? publishList = null;

        lock (_lock) {
            publishList = new List<(Type eventType, Delegate method)>(this.registrationList);
        }

        foreach (var registration in registrationList)
        {
            if (registration.eventType == typeof(T))
                ((Action<T>)registration.method)(data);
                
        }
    }
}
