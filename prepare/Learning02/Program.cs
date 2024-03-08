using System;

class Program 
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Electrical  Engineer";
        job1._company = "Nepal Hydro Power";
        job1._startYear = 2013;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Supervisor";
        job2._company = "Nepal Bagpack";
        job2._startYear = 2016;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Krishna Bahadur Nepali";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}