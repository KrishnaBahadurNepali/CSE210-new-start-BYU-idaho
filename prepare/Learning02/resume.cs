using System;

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>(); // this can helps to make lists for the Jobs that in the resume.cs multiple jobs

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs) // Here green job  data type in th variable job and they all are in the _jobs class
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}