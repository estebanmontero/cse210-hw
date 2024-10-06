using System;
using System.Collections.Generic;

public class Resume 
{
    public string _name = "";

    public List<Job> _jobList= new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        for (int i=0; i < _jobList.Count; i++)
        {
            Job jobs = _jobList[i];
            jobs.Display();
        }
    }
}