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
            Console.WriteLine("Утка кряква:    ");
            MallardDuck duck= new MallardDuck();
            Console.WriteLine(duck.Fly());
            Console.WriteLine(duck.Quack());
            Console.WriteLine("Утка кряква как индейка:    ");
            IDuck turkey2 = duck;
            DuckAdapter da = new DuckAdapter(turkey2);
            Console.WriteLine(da.Fly());
            Console.WriteLine(da.Gobble());
            Console.WriteLine("Дикая индейка:    ");
            WildTurkey wturkey = new WildTurkey();
            ITurkey turkey = wturkey;
            Console.WriteLine(wturkey.Fly());
            Console.WriteLine(wturkey.Gobble());
            Console.WriteLine("Дикая индейка как индейка:    ");
            TurkeyAdapter ta = new TurkeyAdapter(turkey);
            Console.WriteLine(ta.Fly());
            Console.WriteLine(ta.Quack());
            Console.ReadKey();
        }
    }
}
