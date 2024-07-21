
namespace BlazorAppEventAggregator;

public sealed class SubScription : IDisposable
{
    Action method;

    public SubScription(Action method)
    {
        this.method = method;
    }

    public void Dispose()
    {
        if (method is not null)
            method();
    }
}