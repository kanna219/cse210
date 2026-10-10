using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();


        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("Enter file name to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.WriteToFile(saveFile);
                    Console.WriteLine("Journal saved.");
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.ReadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.");
                    Console.WriteLine("");
                    break;

            }
        }
        
    }
}


// Creativity feature: I added writing hints and mood tracking.
// Writing hints help users think of ideas for journal entries.
// Mood tracking lets users record how they felt that day.

