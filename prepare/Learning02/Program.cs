using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "("+ "Microsoft" + ")";
        job1._startYear = 1996;
        job1._endYear = 1997;
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "("+ "Apple" + ")";
        job2._startYear = 1997;
        job2._endYear = 1998;
        // job2.Display();
    
        Resume myResume = new Resume();
        myResume._name = "Rodrigo";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();

        }

        
}