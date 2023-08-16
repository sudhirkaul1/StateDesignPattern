// See https://aka.ms/new-console-template for more information
using StateDesignPattern;
using StateDesignPattern.BusinessLogic;
using StateDesignPattern.States;

Console.WriteLine("Hello, World!");

OrderBooking orderBooking = new OrderBooking(new NewOrderState());

//orderBooking.BookOrder();

//orderBooking.ProcessOrder();

orderBooking.ProcessOrderNext();
orderBooking.ProcessOrderNext();

Console.ReadKey();


