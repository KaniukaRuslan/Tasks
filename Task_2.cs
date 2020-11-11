using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Task_2
    {
        public static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            int a;
            double b;
            long c;
            try
            {
                Console.Write("Введіть a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть c = ");
                c = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception e) { Console.WriteLine("Помилка при приведенні коду. Задані значення за замовчуванням.");
                a = 10;
                b = 10.4;
                c = 344;
             }
            Console.WriteLine($"a={a} b={b} c={c}");
        }
        
    }
}
