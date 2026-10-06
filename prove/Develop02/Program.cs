using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine("Create");
                    break;
                    // Call CreateJournalEntry()
                case 2:
                    Console.WriteLine("Display");
                    break;
                    // Call DisplayJournal()
                case 3:
                    Console.WriteLine("Save");
                    break;
                    // Call readFromFile()
                case 4:
                    Console.WriteLine("Write");
                    // Call WriteToFile()
                    break;

            }
        }
        
    }
}