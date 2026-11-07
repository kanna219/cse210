using System;

class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflection activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");

        int choice;

        while (!int.TryParse(Console.ReadLine(), out choice) ||
               choice < 1 || choice > 4)
        {
            Console.Write("Please enter a number between 1 and 4: ");
        }

        return choice;
    }
}