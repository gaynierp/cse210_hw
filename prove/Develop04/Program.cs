using System;
// For the creativity I used a dictionary to count how many time each activity was run!
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,int> activities = new Dictionary<int, int>()
        {
            {1,0},
            {2, 0},
            {3,0}
        };
        bool run = true;
        while (run){
        Console.WriteLine("Pick an activity:\n1. Breathing activity\n2. Listing activity\n3. Reflection activity\n4. Quit");
        int input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
        BreathingActivity activity = new BreathingActivity("Breathing activity", "Breath in and out");
        activity.RunActivity();
        activities[1] +=1;
        }
        else if (input == 2)
        {
            ListingActivity listActivity = new ListingActivity("Listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            listActivity.RunActivity();
            activities[2] +=1;
        }
        else if (input == 3)
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            reflectionActivity.RunActivity();
            activities[3] +=1;
        }
        else
        {
            run = false;
        }
        }
        Console.WriteLine($"You ran the breathing activity {activities[1]} times");
        Console.WriteLine($"You ran the listing activity {activities[2]} times");
        Console.WriteLine($"You ran the reflection activity {activities[3]} times");
    }   
}