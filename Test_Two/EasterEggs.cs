using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    namespace Test_2
    {
        internal class babada
        {
            static void  trimiliona(string[] args)
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                int eggs = int.Parse(Console.ReadLine()); //int > var 

                for (int i = 0; i < eggs; i++) //)
                {
                    string color = Console.ReadLine();
                    if (dict.ContainsKey(color))
                    {
                        dict[color]++;
                    }
                    else
                    {
                        dict.Add(color, 1);
                    }
                    //добавям 1 else и в него слагам адд,колор,1
                    //и в if-a слагам дикт колор++
                }

                Console.WriteLine($"Red eggs: {(dict.ContainsKey("red") ? dict["red"] : 0)}"); //$
                Console.WriteLine($"Orange eggs: {(dict.ContainsKey("orange") ? dict["orange"] : 0)}");//сменя се позьиц
                Console.WriteLine($"Blue eggs: {(dict.ContainsKey("blue") ? dict["blue"] : 0)}");
                Console.WriteLine($"Green eggs: {(dict.ContainsKey("green") ? dict["green"] : 0)}");
                Console.WriteLine($"Max eggs: {dict.Values.Max()} -> {dict.OrderByDescending(x => x.Value).FirstOrDefault().Key}");
            }
        }
    }
}
