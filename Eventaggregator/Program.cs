

using Eventaggregator;

try
{
    EventAggregator eventAggregator = new();

    using SubScription sub = eventAggregator.Subscribe<Message>((x) => Info(x));

    eventAggregator.Publish(new Message("Test"));


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


static void Info(Message message)
{
    Console.WriteLine($"Event Received : {message.Data}"); 
}

Console.ReadLine();