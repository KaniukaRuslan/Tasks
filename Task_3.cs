using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Task_3
    {
        public static void Main(string[] args)
        {
            int a;
            double b;
            long c;
            while (true)
            {
                try
                {
                    Console.Write("Введіть a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введіть b = ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введіть c = ");
                    c = Convert.ToInt64(Console.ReadLine());
                    break;
                }
                catch (Exception e) { Console.WriteLine("Не правильний тип данних введено. Введіть правильні данні ...");
                                    continue; }
            }
            Console.WriteLine($"a={a} b={b} c={c}");
        }
    }
}
