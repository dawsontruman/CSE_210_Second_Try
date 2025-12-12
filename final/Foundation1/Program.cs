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
        Console.WriteLine();

        Video video2 = new Video("1 hour of cat purring sounds","cat_wuvver",3600);
        video2.AddComment(new Comment("dawsontruman","Thank you so much I love purring noises."));
        video2.AddComment(new Comment("dog_lover","My eternal rival, we meet again..."));
        video2.AddComment(new Comment("observer234","Lol this is the fattest cat I have ever seen."));
        video2.Display();
        Console.WriteLine();

        Video video3 = new Video("Programming with Classses", "Brother_Took", 1023);
        video3.AddComment(new Comment("GandalfTheWhite","Fool of a Took! These inheritance chains are too long!"));
        video3.AddComment(new Comment("the_real_Denethor","I release you from my service. Go now and write whatever classes seem best to you."));
        video3.AddComment(new Comment("dawsontruman", "Second breakfast video when?"));
        video3.Display();
        Console.WriteLine();
    }
}