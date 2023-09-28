using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thLesson_AbstractClasses_Interfaces
{
    public interface IStrategy
    {
        void DoStrategyOperation();
    }
    public class ConcreteStrategyA : IStrategy
    {
        public void DoStrategyOperation() 
        {
            Console.WriteLine($"This is the result of {nameof(ConcreteStrategyA)}");
        }
    }
    public class ConcreteStrategyB : IStrategy
    {
        public void DoStrategyOperation()
        {
            Console.WriteLine($"This is the result of {nameof(ConcreteStrategyB)}");
        }
    }

    public class Context
    {
        private IStrategy Strategy {  get; set; }
        public Context( IStrategy strategy )
        {
            Strategy = strategy;
        }
        public Context()
        {

        }

        public void SetStrategy(IStrategy strategy )
        {
            Strategy = strategy;
        }
        public void DoContextualStrategyOperation()
        {
            Strategy.DoStrategyOperation();
        }
    }

    
}
