using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Введите год на проверку высокосности:");
            int g = Convert.ToInt32(Console.ReadLine());
            if ((g % 4) == 0)
            {
                Console.WriteLine($"{g}г. Является высокосным");
            }
            else
            {
                Console.WriteLine($"{g}г. Не является высокосным");
            }
        }
    }
}
