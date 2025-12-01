using System;
using System.Collections.Generic;


// Definition of an Activity with start and finish times.
class Activity
{
    public int Start { get; set; }
    public int Finish { get; set; }


    // Constructor to initialize an activity.
    public Activity(int start, int finish)
    {
        Start = start;
        Finish = finish;
    }
}


class Program
{
    static void Main()
    {
        // Initialize a list of activities with start and end times.
        List<Activity> activities = new List<Activity>()
        {
            new Activity(1, 4),
            new Activity(3, 5),
            new Activity(0, 6),
            new Activity(5, 7),
            new Activity(8, 9),
            new Activity(5, 9)
        };

        Console.WriteLine("Activities List:\n");
        foreach (var activity in activities)
        {
            Console.WriteLine($"Activity({activity.Start}, {activity.Finish})");
        }

        // Call the function to select the maximum number of non-overlapping activities.
        var selectedActivities = SelectActivities(activities);
        Console.WriteLine("\nSelected activities:\n");
        foreach (var activity in selectedActivities)
        {
            Console.WriteLine($"Activity({activity.Start}, {activity.Finish})");
        }

        // Wait for a key press before closing the console window.
        Console.ReadKey();
    }


    // Function to select the maximum number of non-overlapping activities.
    static List<Activity> SelectActivities(List<Activity> activities)
    {
        // Sort activities based on their finish times.
        activities.Sort((a, b) => a.Finish.CompareTo(b.Finish));
        List<Activity> result = new List<Activity>();

        // Variable to keep track of the last selected activity.
        Activity lastSelectedActivity = null;

        // Iterate through the sorted list of activities.
        foreach (var activity in activities)
        {
            // If no activity has been selected or the current activity starts after the last selected activity finishes.
            if (lastSelectedActivity == null || activity.Start >= lastSelectedActivity.Finish)
            {
                // Add the current activity to the result as it does not overlap.
                result.Add(activity);
                // Update the last selected activity to the current one.
                lastSelectedActivity = activity;
            }
        }
        return result;
    }
}
