using System;

class Program
{
    static void Main(string[] args)
    {
        // int x = 10;
        // int y = 30;
        // int z = 40;

        // if (x == 10 || y == 30 && z == 30)
        // {
        //     Console.WriteLine("X is 10"); 
        //     Console.WriteLine("Y is fun.");
        // }
        // else if (x == 20)
        // {
        //     Console.WriteLine("X is 10");
        // }
        // else
        // {
        //     Console.WriteLine("Default output");
        // }

        // string numberString = "123";
        // int myNumber = int.Parse(numberString);

        // While Loops
        // bool done = false;
        //  while (! done)
        // {
        //     Console.Write("Are we done? (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }

        // bool done = false;
         
        // do
        // {
        //     Console.Write("Are we done? (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y";
        // } while (! done);

        for(double i = 0; i < 1.0; i += 0.01)
        {
            Console.WriteLine(i);
        }

        List<string> myFriends = new List<string> = {"Bob", "Betty", "Bubba"};

        myFriends.Add("Doug");

        foreach(string friend in myFriends)
        {
            Console.WriteLine(friend);
        }
        // For loop

        // Lists List<int> = new list<int>()

        // Functions
    }
}