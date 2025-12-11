using System;

// lol fam I realized a Simple Goal is just a checklist goal with a target of 1 such that it redeems the completion points on the first event
public class SimpleGoal : ChecklistGoal
{
    public SimpleGoal(string description, int completionPoints) : base(description, completionPoints, 0, 1) { }
}