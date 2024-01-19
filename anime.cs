using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WindowWidth = 40;

        int position = 0;

        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(position, 0);
            Console.Write("X");

            Thread.Sleep(100); // Adjust the speed of the animation by changing the sleep duration

            position = (position + 1) % Console.WindowWidth;
        }
    }
}
