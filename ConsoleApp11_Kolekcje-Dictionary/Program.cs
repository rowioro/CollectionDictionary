using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_Kolekcje_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Anna");
            dictionary.Add(4, "Jozef");
            dictionary.Add(3, "Maria");
            if (!dictionary.ContainsKey(2))
                dictionary.Add(2, "Robert");

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}:{1}",item.Key,item.Value);
            }
            Console.ReadKey();
        }
    }
}
