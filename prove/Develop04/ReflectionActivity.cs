using System;
public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();
    private int _reflectionTime;
    public ReflectionActivity(
        int duration,
        int reflectionTime
        ) : base(duration)
    {
        _reflectionTime = reflectionTime;
    }
    public void Run()
    {

    }
}