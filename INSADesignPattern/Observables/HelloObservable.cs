using INSADesignPattern.InputStrategies;
using INSADesignPattern.Observer;
using INSADesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observables
{
    class HelloObservable : IObservable
    {
        private IInputStrategy inputStrategy;

        public int Entier { get; protected set; }

        public void SetInputStrategy(IInputStrategy strategy)
        {
            inputStrategy = strategy;
        }

        public HelloObservable()
        {
            inputStrategy = new FirstHelloStrategy();
        }

        public bool Execute()
        {
            return inputStrategy.RunInputStrategy();
        }
    }
}
