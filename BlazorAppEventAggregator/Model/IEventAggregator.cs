
namespace BlazorAppEventAggregator
{
    public interface IEventAggregator
    {
        void Publish<T>(T data) where T : class;
        SubScription Subscribe<T>(Action<T> action) where T : class;
    }
}