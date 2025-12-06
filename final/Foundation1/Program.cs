using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Let's Cook Mushrooms!","The Mushroom Man",347);
        video1.AddComment(new Comment("Gerden Remsey","It's burnt you donut!"));
        video1.AddComment(new Comment("shroomLover12","I love these tips; can't wait to try this out!"));
        video1.AddComment(new Comment("grand_forager","Which wild mushrooms would this work well with?"));
        video1.Display();
    }
}