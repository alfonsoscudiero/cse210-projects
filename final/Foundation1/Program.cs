using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("6 Investing Habits that Changed My Life", "Investing Simplified", 532);
        Video video2 = new Video("Top 10 Memorial Day Deals 2024", "The Deal Guy", 1026);
        Video video3 = new Video("Learn Visual Studio Code in 7min", "Visual Studio Code", 83);

        // Add comments to video1
        video1.AddComment(new Comment("@ScottLarrry", "Professor I want to personally thank you, you helped me as well as others so much. Thank you very much"));
        video1.AddComment(new Comment("@TheTechCguy", "Big Fan and Subscriber from St. Louis"));
        video1.AddComment(new Comment("@CaptainProx", "Thank you for your research. I find your videos are well done"));

       // Add comments to video2
        video2.AddComment(new Comment("@randyireland8327", "The most wholesome channel on Youtube. Love this guy."));
        video2.AddComment(new Comment("@jacrippin1", "Very impressive how you can flip the items with one hand!"));
        video2.AddComment(new Comment("@sowemovedhere", "Ok the joke about dressing up to make videos in your basement is  worth the thumbs up by itself"));
        video2.AddComment(new Comment("@Leoknightus_", "This video is more Costco drug for my Costco addiction. Thanks!"));

       // Add comments to video3
       video3.AddComment(new Comment("@TomDoesTech", "Been using VSCode now for about 4 years and love it!"));
       video3.AddComment(new Comment("@OnesecoMedia", "I love how Visual Studio Code looked very simple but the reality, it was powerful"));
       video3.AddComment(new Comment("@dichtungundwahrheit", "Great introduction video! VS Code is now really powerful and customizable. Love it!"));
       video3.AddComment(new Comment("@amayacameron1575", "Great straight forward tutorial for beginners, super helpful"));
       video3.AddComment(new Comment("@gasph547", "I got scared when he was typing his favorite theme "));
       
        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3};

        // Iterate through the list to display each video and comments
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }   
        Console.WriteLine();
    }
}