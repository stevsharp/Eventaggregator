

namespace BlazorAppEventAggregator;

internal class CustomerService
{
    protected readonly IEventAggregator _eventAggregator;

    public CustomerService(IEventAggregator eventAggregator) => _eventAggregator = eventAggregator;

    public void CreateMessage()
    {
        _eventAggregator.Publish(new Message("Create Message"));
    }


}
