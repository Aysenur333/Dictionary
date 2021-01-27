using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Dictionary<string, int> letterNumber1 = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 }
            };
                Console.WriteLine(letterNumber1["a"]);
                Console.WriteLine(letterNumber1["b"]);
                foreach (var show in letterNumber1)
                {
                    Console.WriteLine(show);
                }
                Console.WriteLine("Part of no Add");
                letterNumber1.Add("c", 3);
                foreach (var show2 in letterNumber1)
                {
                    Console.WriteLine(show2);
                }

                Console.WriteLine("C# own dictionary part till here");
                Console.WriteLine("********************************");
                Console.WriteLine("My own dictionary part starts from here");
                MyDictionary<string, int> letterNumber2 = new MyDictionary<string, int>();
                letterNumber2.Add("a", 1);
                letterNumber2.Add("b", 2);
                letterNumber2.Add("c", 3);
                letterNumber2.Add("d", 4);
                Console.WriteLine("own dictionary part ends here");

            }
        }
    }
}
