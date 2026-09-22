using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 30;
        int z = 40;

        if (x == 10 || y == 30 && z == 30)
        {
            Console.WriteLine("X is 10"); 
            Console.WriteLine("Y is fun.");
        }
        else if (x == 20)
        {
            Console.WriteLine("X is 10");
        }
        else
        {
            Console.WriteLine("Default output");
        }

        string numberString = "123";
        int myNumber = int.Parse(numberString);
    }
}