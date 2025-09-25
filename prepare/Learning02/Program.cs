using System;

class Program
{
    static void Main(string[] args)
    {
        // create a new resume
        Resume resume = new Resume("Dawson Truman");
        // add that cool Microsoft job
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        resume.AddJob(job1);
        // add that lame Apple manager job I have to leave after one year
        Job job2 = new Job("Apple", "Manager", 2022, 2023);
        resume.AddJob(job2);
        // display resume
        resume.Display();
    }
}