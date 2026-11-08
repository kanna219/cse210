using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int choice = 0;

        while (choice != 4)
        {
            choice = menu.DisplayMenu();

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

                breathingActivity.RunActivity();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity(
                    "Reflection",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                reflectionActivity.RunActivity();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life.");

                listingActivity.RunActivity();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }

            Console.WriteLine();
        }
    }
}

// Creativity and Exceeding Requirements:
// I added a feature that prevents random prompts and questions
// from repeating until all of them have been used at least once.
// After all prompts or questions have been used, the program
// resets them so they can be selected again.