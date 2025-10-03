using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Web Designer";
        job1._startYear = 2021;
        job1._endYear = 2024;
        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2022;
        job2._endYear = 2025;
        //job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Ann Helms";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();


    }
}