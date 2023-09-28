using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thLesson_AbstractClasses_Interfaces
{
    public interface IComponent
    {
        public void Operation();
    }

    class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("I am a base operation, hello there!");
        }
    }
    public abstract class Decorator : IComponent 
    {
        protected IComponent _Component;

        public Decorator(IComponent component)
        {
            this._Component = component;
        }

        public void Operation()
        {
            if (_Component != null)
            {
                _Component.Operation();
            }
        }
        
    }

    public class ConcreteDecorator1 : Decorator
    {
        public ConcreteDecorator1(IComponent component) 
            : base(component)
        {

        }
        public void Operation()
        {
            base.Operation();
            Console.WriteLine("I am a first added operation, ready to help!");
        }
    }

    public class ConcreteDecorator2 : Decorator
    {
        public ConcreteDecorator2(IComponent component)
            :base(component)
        {

        }

        public void Operation()
        {
            base.Operation();
            Console.WriteLine("I am a second added operation, let me handle this stuff");
        }
    }
}
