using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Beginners Guide", "C# Tutorials", 123456);
        video1.AddComment("John Doe 1", "Great tutorial! But Typescript is better");
        video1.AddComment("John Doe 2", "Great tutorial! But GoLang is better");
        video1.AddComment("John Doe 3", "Great tutorial! But Java is better");

        Video video2 = new Video("GoLang Beginners Guide", "GoLang Tutorials", 654321);
        video2.AddComment("Gohn Foe 1", "Great tutorial! But Typescript is better");
        video2.AddComment("Gohn Foe 2", "Great tutorial! But C# is better");
        video2.AddComment("Gohn Foe 3", "Great tutorial! But Java is better");

        Video video3 = new Video("SQL Beginners Guide", "SQL Tutorials", 987654);
        video3.AddComment("Lohn Poe 1", "Great tutorial! But PostgreSQL is better");
        video3.AddComment("Lohn Poe 2", "Great tutorial! But MongoDB is better");
        video3.AddComment("Lohn Poe 3", "Great tutorial! But DynamoDB is better");
        video3.AddComment("Lohn Poe 4", "Great tutorial! But MariaDB is better");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine();
            string title = video.GetTitle();
            string author = video.GetAuthor();
            int duration = video.GetDuration();
            int commentsCount = video.GetCommentsCount();

            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Duration: {duration} seconds");
            Console.WriteLine($"{commentsCount} comments: ");
            Console.WriteLine();
            video.ShowComments();
        }
    }
}