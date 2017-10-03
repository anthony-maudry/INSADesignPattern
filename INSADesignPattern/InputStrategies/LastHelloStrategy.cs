using INSADesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.InputStrategies
{
    class LastHelloStrategy : IInputStrategy
    {
        public bool RunInputStrategy()
        {
            Console.WriteLine($"Ok, {Program.UserName}, I understand you’re very polite. Please stop that game.");

            return true;
        }
    }
}
