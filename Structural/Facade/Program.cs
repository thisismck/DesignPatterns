// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");

/*
 * * Facade Pattern
 * * * 
 * * * Definition: Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
 * * * 
 * * * The Facade pattern is used to provide a simplified interface to a complex system. The facade object provides a single, simplified interface to the more complex system, making it easier to use.
 * * * 
 * * * The Facade pattern is used when you need to provide a simplified interface to a complex system. This can be useful in a number of situations, such as:
 * * * - When you need to provide a simplified interface to a complex system.
 * * * - When you need to provide a single interface to a number of different interfaces.
 * * * - When you need to provide a single interface to a number of different objects.
 * * * - When you need to provide a single interface to a number of different subsystems.
 * * * 
 * * * The Facade pattern is used in a number of different ways, such as:
 * * * - Simplifying a complex system: The facade object provides a simplified interface to a complex system, making it easier to use.
 * * * - Providing a single interface to a number of different interfaces: The facade object provides a single interface to a number of different interfaces, making it easier to use.
 * * * - Providing a single interface to a number of different objects: The facade object provides a single interface to a number of different objects, making it easier to use.
 * * * - Providing a single interface to a number of different subsystems: The facade object provides a single interface to a number of different subsystems, making it easier to use.
 * * * 
 * * * The Facade pattern is used in a number of different scenarios, such as:
 * * * - Simplifying a complex system: A facade can be used to provide a simplified interface to a complex system.
 * * * - Providing a single interface to a number of different interfaces: A facade can be used to provide a single interface to a number of different interfaces.
 * * * - Providing a single interface to a number of different objects: A facade can be used to provide a single interface to a number of different objects.
 * * * - Providing a single interface to a number of different subsystems: A facade can be used to provide a single interface to a number of different subsystems.
 * * * 
 * * * The Facade pattern is used in a number of different programming
 * 
 * 
 * Çok fazla nesne kullanarak çok karmaşık işler yapmanız gereken bir senaryonuz var; bu durumda Facade Pattern kullanabilirsiniz. 
 * Facade Pattern, karmaşık bir sistemi basitleştirmek için kullanılır. Facade Pattern, bir alt sistemdeki bir grup nesneye tek 
 * bir arayüz sağlar. Bu, alt sistemdeki nesnelerin kullanımını kolaylaştırır.
 */

OrderService orderService = new OrderService();

Customer customer = new Customer
{
    Name = "Ali",
    Surname = "Veli",
    Email = ""
};

List<CardItem> cardItems = new List<CardItem>
{
    new CardItem
    {
        Product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Stock = 100
        },
        Quantity = 2
    },
    new CardItem
    {
        Product = new Product
        {
            Id = 2,
            Name = "Mouse",
            Stock = 200
        },
        Quantity = 1
    }
};

orderService.CreateOrder(customer, cardItems);