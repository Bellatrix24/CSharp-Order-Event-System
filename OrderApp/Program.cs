using System;
using OrderApp;
using OrderApp.Services;

// creating the processor
OrderProcessor processor = new OrderProcessor();

// creating the services
EmailService emailService = new EmailService();
SMSService smsService = new SMSService();
LoggerService loggerService = new LoggerService();

// subscribing all services to the event using +=
processor.OnOrderPlaced += emailService.SendEmail;
processor.OnOrderPlaced += smsService.SendSMS;
processor.OnOrderPlaced += loggerService.LogOrder;

// creating a test order and processing it
Order order1 = new Order();
order1.OrderId = 101;
order1.CustomerName = "Alice";
order1.Amount = 250.75;

processor.ProcessOrder(order1);
