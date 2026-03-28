using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("Best of lionel Messi", "Prince bolton", 689);
        Comment comment1 = new Comment("Osawaru kingsley", "wow what a performance by lionel messi");
        Comment comment2 = new Comment("prince wells", "magical messi");
        Comment comment3 = new Comment("Adam steve", "Ohh My world!!, magical messi");
        Comment comment4 = new Comment("clark newton", "beautiful by lionel messi");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);
        videos.Add(video1);

        Video video2 = new Video("lion and the snake", "james clark", 567);
        Comment comment5 = new Comment("kate","animal survival");
        Comment comment6 = new Comment("Esther", "flawless win");
        Comment comment7 = new Comment("Andrew Wilson", "animal chaos");
        Comment comment8 = new Comment("Kenneth", "Nice fight");   
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);
        videos.Add(video2);


        Video video3 = new Video("Temple Beatify", "Adam Kane", 678);
        Comment comment9 = new Comment("Edward prince", "house of the lord");
        Comment comment10 = new Comment("Edith praise", "beautiful is the house of the lord");
        Comment comment11= new Comment("kingsley osas", "I love the temple");
        Comment comment12= new Comment("Akon smith", "Look forward to visit the temple");    
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);
        videos.Add(video3);


        Video video4 = new Video("The voice of the prophet","Agon walter", 890);
        Comment comment13 = new Comment("kingston", "God bless our Prophet");
        Comment comment14= new Comment("Philip", "I sustain the prophet");
        Comment comment15= new Comment("John Lamn", "Thank God for a prophet voice");
        Comment comment16= new Comment("Aston villa", "God is love");
        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);
        videos.Add(video4);

        foreach (Video video in videos)
        {
          video.Display();  
        }


        

    


        

        

    }
}