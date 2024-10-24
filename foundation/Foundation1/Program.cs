using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Creating author instances of the Person class
        Person author1 = new Person("Mr.", "Alex", "Johnson");
        Person author2 = new Person("Ms.", "Emily", "Clark");
        Person author3 = new Person("Dr.", "Michael", "Taylor");
        Person author4 = new Person("Prof.", "Sarah", "Davis");

        // Initializing video objects with their respective authors
        Video video1 = new Video("Getting Started with C#", author1, 360);
        Video video2 = new Video("Watercolor Techniques", author2, 480);
        Video video3 = new Video("SQL for Beginners", author3, 720);
        Video video4 = new Video("Mastering JavaScript", author4, 600);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Creating commenter instances of the Person class
        Person commenter1 = new Person("Ms.", "Sophia", "Green");
        Person commenter2 = new Person("Mr.", "Liam", "Brown");

        // Adding user feedback on the videos
        video1.AddComment(new Comment(commenter1, "Great introduction!"));
        video1.AddComment(new Comment(commenter2, "Very informative."));

        video2.AddComment(new Comment(new Person("Mr.", "Noah", "White"), "This tutorial is fantastic!"));
        video2.AddComment(new Comment(new Person("Ms.", "Olivia", "Miller"), "Loved the techniques!"));

        video3.AddComment(new Comment(new Person("Ms.", "Ava", "Wilson"), "Very clear explanation of SQL."));
        video3.AddComment(new Comment(new Person("Mr.", "Ethan", "Moore"), "Can't wait for the next one!"));

        video4.AddComment(new Comment(new Person("Mr.", "James", "Harris"), "Excellent course!"));
        video4.AddComment(new Comment(new Person("Ms.", "Isabella", "Clark"), "I learned so much from this."));

        // Outputting the details of each video along with comments
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}



