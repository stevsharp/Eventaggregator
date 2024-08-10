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

bash
git clone https://github.com/your-username/EventAggregator.git

### Usage
### Here's an example of how to use the EventAggregator:

EventAggregator eventAggregator = new();

using SubScription sub = eventAggregator.Subscribe<Message>((x) => Info(x));

eventAggregator.Publish(new Message("Test"));

static void Info(Message message)
    {
        Console.WriteLine($"Event Received : {message.Data}");
    }
}

## Connect with Me

[![LinkedIn](https://img.shields.io/badge/LinkedIn-Profile-blue)](https://www.linkedin.com/in/spyros-ponaris-913a6937/)
