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

            Dictionary<Duck, int> DuckDict = new Dictionary<Duck, int>();
            List <Duck> DuckList = new List<Duck>();

            DuckDict.Add(quack, 1);
            DuckDict.Add(quackFrench, 2);
            DuckDict.Add(quackChinese, 3);
            DuckDict.Add(quackFunny, 4);
            //DuckDict.Add(quackSame, 5);
            DuckDict.Add(quackSimilar, 6);

            DuckList.Add(quack);
            DuckList.Add(quackFrench);
            DuckList.Add(quackChinese);
            DuckList.Add(quackFunny);
            DuckList.Add(quackSame);
            DuckList.Add(quackSimilar);

            if (DuckDict.ContainsKey(quackFunny)) { Console.WriteLine("It's here"); }

            if (quack.Equals(quackSame)) { Console.WriteLine("Quack and QuackSame are equal"); }
            if (quack == quackSame) { Console.WriteLine("Quack and QuackSame are =="); }
            if (quack.Equals(quackSimilar)) { Console.WriteLine("These two ducks are equal"); }

            foreach (KeyValuePair<Duck, int> duck in DuckDict)
            {
                Console.WriteLine("Key {0}, value {1}", duck.Key, duck.Value);
            }

            DuckList.Sort(Duck.NameComparer);

            foreach (var duck in DuckList)
            {
                Console.WriteLine("Name {0}, Type {1}", duck.Name, duck.Type);
            }

            Console.ReadLine();
        }
    }
}
