using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of Video// These are creating using learning knowledge from week 04 and 05
        Video video1 = new Video("Learning C#", "John Doe", 600);//These are the string parameters that passes to the Video class
        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 1200);
        Video video3 = new Video("C# Design Patterns", "Alex Johnson", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Clear and concise."));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Advanced but well explained."));
        video2.AddComment(new Comment("Eva", "Loved the examples."));

        // Add comments to video3
        video3.AddComment(new Comment("Frank", "Design patterns made easy."));
        video3.AddComment(new Comment("Grace", "Excellent content."));
        video3.AddComment(new Comment("Hannah", "Good overview."));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");//Specifies Title, Author and Lenght
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");//Direct excess

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(); // Blank line for separation between videos
        }
    }
}
