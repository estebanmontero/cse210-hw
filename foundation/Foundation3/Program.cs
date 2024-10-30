using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List to store various activities
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 3.0),        // Running activity: 3 miles in 30 min
            new Cycling(DateTime.Now, 40, 12.0),       // Cycling activity: 12 mph for 40 min
            new Swimming(DateTime.Now, 45, 20)         // Swimming activity: 20 laps in 45 min
        };

        // Print summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
