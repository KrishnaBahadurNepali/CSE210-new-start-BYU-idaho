using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create list to hold activities
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type and add them to the list
        activities.Add(new Running(new DateTime(2024, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2024, 11, 3), 45, 25.0));
        activities.Add(new Swimming(new DateTime(2024, 11, 3), 60, 20));

        // Display summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

