namespace _14thLesson_AbstractClasses_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            Console.WriteLine("Are two variables of the singleton refer to the same address? " + (singleton1 == singleton2) + "\n");

            var concreteComponent = new ConcreteComponent();

            ConcreteDecorator1 concreteDecorator1 = new ConcreteDecorator1(concreteComponent);
            ConcreteDecorator2 concreteDecorator2 = new ConcreteDecorator2(concreteDecorator1);

            concreteDecorator1.Operation();
            concreteDecorator2.Operation();

            ConcreteFactory1 concreteFactory1 = new ConcreteFactory1();

            var concreteProductA = concreteFactory1.CreateProductA();
            var concreteProductB = concreteFactory1.CreateProductB();
            Console.WriteLine(concreteProductB.ExampleInteractionWithProduct1(concreteProductA));
            Console.WriteLine();

            var context = new Context();

            context.SetStrategy(new ConcreteStrategyA());
            context.DoContextualStrategyOperation();
            context.SetStrategy(new ConcreteStrategyB());
            context.DoContextualStrategyOperation();

        }
    }
}