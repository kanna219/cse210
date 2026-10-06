class Menu
{
    
    public int ProcessMenu()
    {
        Console.WriteLine($"In the menu class");

        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Create, Display, Save, or read Jonal Entries.");
            Console.WriteLine("1. Create new jornal entry.");
            Console.WriteLine("2. Display all journal entries.");
            Console.WriteLine("3. Save journal to a file.");
            Console.WriteLine("4. Read journal from a file.");
            Console.WriteLine("5. Quit.");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
            
        }
        return input;
    }
}