using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var quackFrench = new Duck("Al Orange", "Muscovy", 200, 12);
            var quackChinese = new Duck("Crispy", "Mandarin", 150, 10);
            var quackFunny = new Duck("Monty", "Swedish Blue", 140, 14);
            var quackSame = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var quackSimilar = new Duck("Sir Quickalot", "Mallard", 100, 17);

            if (quack.Equals(quackSame)) { Console.WriteLine("Quack and QuackSame are equal"); }
            if (quack == quackSame) { Console.WriteLine("Quack and QuackSame are =="); }
            if (quack.Equals(quackSimilar)) { Console.WriteLine("These two ducks are equal"); }
            Console.ReadLine();
        }
    }
}
