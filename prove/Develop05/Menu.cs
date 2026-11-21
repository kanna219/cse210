class Menu
{
    public int DisplayMenu()
    {
        int choice = 0;

        while (choice < 1 || choice > 6)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());
        }

        return choice;
    }

    public int DisplayCreateGoalMenu()
    {
        int goalType = 0;

        while (goalType < 1 || goalType > 3)
        {
            Console.WriteLine();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            goalType = int.Parse(Console.ReadLine());
        }

        return goalType;
    }
}