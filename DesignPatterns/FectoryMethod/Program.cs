

using FectoryMethod.Factory;

Console.WriteLine("First Factory....");
ClientCode(new ConcreteFactory1());

Console.WriteLine("\nSecond Factory....");
ClientCode(new ConcreteFactory2());

static void ClientCode(Creator creator)
{
    Console.WriteLine($"Creator worked for...\n" + creator.DoSomething());
}