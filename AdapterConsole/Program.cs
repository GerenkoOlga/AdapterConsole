using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck turkey = new MallardDuck();
            Console.WriteLine(turkey.Fly());
            Console.WriteLine(turkey.Quack());
           
            WildTurkey wturkey = new WildTurkey();
            Console.WriteLine(wturkey.Fly());
            Console.WriteLine(wturkey.Gobble());
            Console.ReadKey();
        }
    }
}
