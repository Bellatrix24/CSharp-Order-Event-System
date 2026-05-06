# CSharp-Order-Event-System

A simple console app that demonstrates how **delegates** and **events** work in C#. Built as part of a training assignment.

## What This Project Does

This is a basic order processing system for an e-commerce kind of scenario. When an order is placed, it notifies different services like Email, SMS, and Logger - all using events so that the code stays loosely coupled.

Basically the idea is:
- `OrderProcessor` is the **publisher** - it fires an event when an order gets processed
- `EmailService`, `SMSService`, `LoggerService` are the **subscribers** - they listen to that event and do their own thing

## Concepts Used

- **Delegates** - defined a custom delegate `OrderPlacedHandler` to set the method signature
- **Events** - used the `event` keyword so that subscribers can hook into the order processing
- **Multicast Delegates** - multiple methods are attached to the same event using `+=`
- **Publisher-Subscriber Pattern** - the processor doesn't know or care about who is listening, it just fires the event

## Project Structure

```
/OrderApp
├── Program.cs            --> entry point, sets everything up
├── Order.cs              --> the Order model class
├── OrderProcessor.cs     --> processes orders and raises events
├── Services/
│   ├── EmailService.cs   --> sends email notification
│   ├── SMSService.cs     --> sends sms notification
│   └── LoggerService.cs  --> logs the order
```

## How to Run

Make sure you have .NET SDK installed, then:

```
cd OrderApp
dotnet run
```

## Output

```
Order Placed: 101
Email sent to customer
SMS sent to customer
Order logged successfully
```

## What I Learned

- How to create and use delegates in C#
- How events help in decoupling different parts of the code
- How multicast delegates let you attach more than one method to the same event
- The publisher-subscriber model and why it's useful in real applications


