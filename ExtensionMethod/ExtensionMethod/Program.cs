using System;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork(int x)
        {
            for (int i = 2; i <= 16; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number to convert:");
            int x = Convert.ToInt32(Console.ReadLine());
            try
            {
                doWork(x);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
