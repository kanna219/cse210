using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("Moses", 1, 39,
        "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man");

        myScripture.ShowScripture();

        while (true)
        {
            if (myScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            myScripture.HideSomeWords();

            Console.Clear();

            myScripture.ShowScripture();
        }
    }
}

// For creativity, I added a feature that only selects words that are not already hidden.
// This prevents the program from choosing the same hidden word again
// and makes the memorization practice more effective.