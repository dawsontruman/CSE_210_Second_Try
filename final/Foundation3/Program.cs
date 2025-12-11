using System;

class Program
{
    static void Main(string[] args)
    {
        // generic Event
        Address bdayAddress = new Address("431 S 3rd W", "Rexburg", "Idaho", "United States");
        Event birthdayParty = new Event("Dawson's Birthday", "Sad 27th birthday come pity me", "05/14/2026","7:00 PM", bdayAddress);
        Console.WriteLine(birthdayParty.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(birthdayParty.FullDetails());
        Console.WriteLine();
        Console.WriteLine(birthdayParty.ShortDescription());
        Console.WriteLine();

        // Lecture
        Address lgtcAddress = new Address("One Microsoft Way", "Redmond", "Washington", "United States");
        Lecture lightGrayTerracotta = new Lecture("Light Gray Terracotta Facts", "Kick off a New Year 12 years ago by reviewing important facts about Light Gray Terracotta, a seldom appreciated block in the popular game Minecraft", "01/01/2013","3:00 AM", lgtcAddress, "A YouTuber whose name I forgot", 9001);
        Console.WriteLine(lightGrayTerracotta.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(lightGrayTerracotta.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lightGrayTerracotta.ShortDescription());
        Console.WriteLine();

        // Reception
        Address litterAddress = new Address("Puppy Street", "Dogtown", "Muttland", "Canine Federation");
        Reception litterShower = new Reception("Litter Shower", "Cute dogs had babies, come celebrate!", "8/17/2029","2:00 PM", litterAddress, "dogmatchmaker67@dogmail.com");
        Console.WriteLine(litterShower.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(litterShower.FullDetails());
        Console.WriteLine();
        Console.WriteLine(litterShower.ShortDescription());
        Console.WriteLine();

        // OutdoorGathering
        Address hikeAddress = new Address("Western Slope", "Slopes of Mount Doom", "Mt. Doom Volcanic Region", "Mordor");
        OutdoorGathering hike = new OutdoorGathering("23rd Annual Mt. Doom Hike", "Join Samwise Gamgee on a scenic hike up the slopes of Mt. Doom.", "05/14/2026","12:00 PM", hikeAddress, "100% chance of cloudy weather, lava flow warning");
        Console.WriteLine(hike.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(hike.FullDetails());
        Console.WriteLine();
        Console.WriteLine(hike.ShortDescription());
        Console.WriteLine();
    }
}