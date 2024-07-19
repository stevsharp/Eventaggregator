# EventAggregator

A simple and thread-safe event aggregator for .NET 8 applications, allowing for decoupled communication between different parts of your application through event subscription and publishing.

## Features

- Thread-safe event subscription and publishing.
- Easy subscription and unsubscription using the `SubScription` class.
- Supports any event type through generics.

## Getting Started

### Prerequisites

- .NET 8 SDK

### Installation

Clone the repository:

```bash
git clone https://github.com/your-username/EventAggregator.git

Usage
Here's an example of how to use the EventAggregator:

csharp
Copy code
using Eventaggregator;
using System;

public record Message(string Data);

public class Program
{
    static void Main()
    {
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

        Console.ReadLine();
    }

    static void Info(Message message)
    {
        Console.WriteLine($"Event Received : {message.Data}");
    }
}
Explanation
Subscribe to an Event:

csharp
Copy code
using SubScription sub = eventAggregator.Subscribe<Message>((x) => Info(x));
This line subscribes the Info method to Message events. The Subscribe method returns a SubScription object, which, when disposed, will remove this subscription.

Publish an Event:

csharp
Copy code
eventAggregator.Publish(new Message("Test"));
This line publishes a Message event. If sub has not been disposed of, the Info method will be called.

Handle the Event:

csharp
Copy code
static void Info(Message message)
{
    Console.WriteLine($"Event Received : {message.Data}");
}
This method is called when a Message event is published and prints the event data to the console.

Unsubscribe from the Event:

csharp
Copy code
sub.Dispose();
If the Dispose method is called (which happens automatically when exiting the using block), the subscription is removed from the registrationList, and the Info method will no longer be called on subsequent Publish calls.

Contributing
Fork the repository.
Create a new branch (git checkout -b feature-branch).
Commit your changes (git commit -m 'Add some feature').
Push to the branch (git push origin feature-branch).
Open a pull request.
License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
For any questions or feedback, please open an issue or reach out to your-email@example.com.

javascript
Copy code

To create this as a `README.md` file, you can copy the above content and paste it into a new file named `README.md` in the root directory of your project. Make sure to replace `your-username` with your actual GitHub username and `your-email@example.com` with your actual email address.





