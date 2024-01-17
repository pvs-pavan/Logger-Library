# Logger Library

## Overview

The Logger Library is designed to provide a logging solution for .NET applications. 
It allows client applications to seamlessly log messages to various sinks (destinations)

### Key Features 

- **Message Logging:** 

- **Sinks:** 

- **Logger Configuration:** The library requires configuration during sink setup. It accepts messages from clients, routes them to the appropriate sink based on the specified level, and supports message levels in the order of priority: FATAL, ERROR, WARN, INFO, DEBUG. Specifies all the details required to use the logger library. The library can accept one or more configurations for an application. 


## Design Pattern

The Logger Library follows the following design patterns: 


-**Singleton Pattern:** The `Logger` class is implemented as a singleton to ensure a single instance is shared across the application.

-**Strategy Pattern:** The library uses the Strategy pattern for handling different message sinks (`IMessageSink` implementations).

## Getting Started

To use the Logger library, follow the steps below: 

1. **Installation:**

Clone the repository or add the Logger library as a reference in your project. 

2. **Configuration:** 

Configure the Logger in your client project using the `LoggerBuilder`:

 ```csharp

 var logger = new LoggerBuilder().AddSink(new ConsoleSink()).AddSink(new FileSink()).Build();
 
 logger.LogMessage("this is error message", LogLevel.Error, "ApplicationNamespace");
 
 ```
 
