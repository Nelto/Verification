using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verification
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args[0].Equals("?")) Console.WriteLine("Введите имя входного файла");
            else
            {
                Verific verific = new Verific(args[0]);
                Console.WriteLine("Кол-во сгенерированных символов:");
                verific.PrintCountingRes();
                Console.WriteLine("\nУсловные вероятности:");
                verific.PrintChances();
                Console.ReadLine();
            }
        }
    }
}
