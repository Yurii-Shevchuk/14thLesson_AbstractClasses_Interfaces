using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thLesson_AbstractClasses_Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    public interface IAbstractProductA
    {
        string ExampleOperation1();
    }

    public class ConcreteProductA1 : IAbstractProductA
    {
        public string ExampleOperation1()
        {
            return "This is A1 product";
        }
    }

    public interface IAbstractProductB
    {
        string ExampleOperation2();

        string ExampleInteractionWithProduct1(IAbstractProductA productA);
    }

    public class ConcreteProductB1 : IAbstractProductB
    {
        public string ExampleOperation2()
        {
            return "This is B1 product";
        }
        public string ExampleInteractionWithProduct1(IAbstractProductA concreteProductA)
        {
            return $"By cooperation of {nameof(ConcreteProductB1)} and cooperation only we found out next information -> {concreteProductA.ExampleOperation1()}";
        }
    }

    
}
