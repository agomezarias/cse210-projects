using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Learning C# (Beginners)";
        video1._author = "John Ryan";
        video1._length = 120;
        
        Comment comment1 = new Comment();
        comment1._commenterName = "Jimmy";
        comment1._commentText = "This video was soooo helpful.";
        
        Comment comment2 = new Comment();
        comment2._commenterName = "Sarah";
        comment2._commentText = "This video helped me so much while trying to learn this Language.";

        Comment comment3 = new Comment();
        comment3._commenterName = "Jack";
        comment3._commentText = "What would be the easiest way to start learning C#?";

        video1._comments = new List<Comment>();
        {
            video1._comments.Add(comment1);
            video1._comments.Add(comment2);
            video1._comments.Add(comment3);
        }
        

        Video video2 = new Video();
        video2._title = "The Best Way to Learn C#";
        video2._author = "Jane Smith";
        video2._length = 200;
        
        Comment comment4 = new Comment();
        comment4._commenterName = "Josh";
        comment4._commentText = "Such great info.";
        
        Comment comment5 = new Comment();
        comment5._commenterName = "Sean";
        comment5._commentText = "This video is very helpful, thank you for this information.";

        Comment comment6 = new Comment();
        comment6._commenterName = "Jose";
        comment6._commentText = "Muchas gracias por la ayuda.";

        video2._comments = new List<Comment>();
        {
            video2._comments.Add(comment4);
            video2._comments.Add(comment5);
            video2._comments.Add(comment6);
        }


        Video video3 = new Video();
        video3._title = "Why is C# worth learning?";
        video3._author = "Tim The Coder";
        video3._length = 240;
        
        Comment comment7 = new Comment();
        comment7._commenterName = "Ron";
        comment7._commentText = "I didn't want to learn C# before this information, thank you for explaining";
        
        Comment comment8 = new Comment();
        comment8._commenterName = "Rachelle";
        comment8._commentText = "I too would highly consider learning C# for my personal development..";

        Comment comment9 = new Comment();
        comment9._commenterName = "Richard";
        comment9._commentText = "Thank you for the info, could you show me a real world application for using C#?.";

        video3._comments = new List<Comment>();
        {
            video3._comments.Add(comment7);
            video3._comments.Add(comment8);
            video3._comments.Add(comment9);
        }


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
        
    }
}