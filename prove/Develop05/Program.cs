class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();

        bool running = true;

        while (running)
        {
            goals.DisplayScore();
            int choice = menu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    int goalType = menu.DisplayCreateGoalMenu();

                    if (goalType == 1)
                    {
                        goals.AddGoal(new SimpleGoal());
                    }
                    else if (goalType == 2)
                    {
                        goals.AddGoal(new EternalGoal());
                    }
                    else if (goalType == 3)
                    {
                        goals.AddGoal(new CheckListGoal());
                    }
                    break;

                case 2:
                    Console.WriteLine("The goals are:");
                    goals.DisplayGoals();
                    break;

                case 3:
                    goals.SaveGoals();
                    break;

                case 4:
                    goals.LoadGoals();
                    break;

                case 5:
                    goals.RecordEvent();
                    break;

                case 6:
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }
}