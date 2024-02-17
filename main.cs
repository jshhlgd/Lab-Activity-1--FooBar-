using System;

class Program
{
    static void Main(string[] args)
    {
        int X = 30;

        for (int i = 1; i <= X; i++)
        {
            if (i % 3 == 0)
            {
              Console.WriteLine($"{i} - Foo");
            
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}