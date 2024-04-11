using System;

namespace Example
{
    class Program
    {
        static void Main()
        {
            for (int number = 10; number <= 100; number++)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
