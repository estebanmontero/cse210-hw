using System;


class Program
{
    static void Main(string[] args)
    {
        //create 2 new instances to call on the Job class
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        job2.Display();
        Console.WriteLine();


        //create a new instance to call on the resume class
        Resume resume = new Resume();
        resume._name = "Flourish Idahosa-Sunny";

        //add the created jobs into the list in the resume instance
        resume._jobList.Add(job1);
        resume._jobList.Add(job2);
        resume.Display();

    }
    
}