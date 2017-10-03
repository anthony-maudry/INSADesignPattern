using INSADesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.InputStrategies
{
    class FirstHelloStrategy : IInputStrategy
    {
        public bool RunInputStrategy()
        {
            Console.WriteLine("Hello, what's your name ?");
            Program.UserName = Console.ReadLine();
            Console.WriteLine($"Hello, {Program.UserName}, nice to meet you.");
            Program.UserSaidHello();

            return true;
        }
    }
}
