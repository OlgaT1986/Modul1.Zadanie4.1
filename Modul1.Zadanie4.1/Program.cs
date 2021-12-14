using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, resul = 0;
            string K;
            Console.WriteLine("Введите N");
            K = Console.ReadLine();
            if (int.TryParse(K, out n))
            {
                n = Convert.ToInt32(K);
                if (n > 0)
                {
                    for (int i = 1; i <= 2 * n - 1; i += 2)
                    {
                        resul = resul + (2 * i - 1);
                        Console.WriteLine("При N=" + i + " результат суммы квадратов = " + resul);
                    }
                }
                else
                { Console.WriteLine("Введенное N<=0"); }
            }
            else { Console.WriteLine("Введенное число N не является целым число. Вводить только целые числа"); }
            Console.ReadKey();

        }
    }
}
