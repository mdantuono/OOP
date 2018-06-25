using System;

namespace divisibleCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
