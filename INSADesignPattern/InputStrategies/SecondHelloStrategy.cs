using INSADesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.InputStrategies
{
    class SecondHelloStrategy : IInputStrategy
    {
        public bool RunInputStrategy()
        {
            Console.WriteLine($"Yes {Program.UserName}, I remember you.");
            Program.UserSaidHello();

            return true;
        }
    }
}
