using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observer
{
    class Observer
    {
        /// <summary>
        /// The list of listeners
        /// </summary>
        private Dictionary<string, List<IObservable>> listeners;

        /// <summary>
        /// Constructor. Initializes the listeners list
        /// </summary>
        public Observer()
        {
            listeners = new Dictionary<string, List<IObservable>>();
        }

        /// <summary>
        /// Registers a listener for an input
        /// </summary>
        /// <param name="input"></param>
        /// <param name="func"></param>
        public void Register(string input, IObservable observable)
        {
            // If the listener list does not contain the input ...
            if (!listeners.ContainsKey(input))
                // ... add a list for that input
                listeners.Add(input, new List<IObservable>());

            listeners.Single(p => p.Key == input).Value.Add(observable);
        }

        /// <summary>
        /// Unregisters a listener
        /// </summary>
        /// <param name="input"></param>
        /// <param name="func"></param>
        public void Unregister(string input, IObservable observable)
        {
            if (!listeners.ContainsKey(input))
                return;

            listeners.Single(p => p.Key == input).Value.Remove(observable);
        }

        /// <summary>
        /// triggers an event
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Trigger(string input)
        {
            List<IObservable> inputListeners = listeners.SingleOrDefault(p => p.Key == input).Value;

            if (inputListeners == null || inputListeners.Count == 0)
                return false;

            foreach (IObservable observable in inputListeners)
            {
                if (!observable.Execute())
                    return true;
            }

            return true;
        }
    }
}
