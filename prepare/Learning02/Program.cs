using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "doc-IT";
        job1._jobTitle = "Support Technician";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Purple Turtle";
        job2._jobTitle = "Designer";
        job2._startYear = 2020;
        job2._endYear = 2021;


        //job1.Display();
        //job2.Display();

        Resume myresume = new Resume();
        myresume._name = "Jarod Ramos";
        myresume._jobs = new List<Job>();

        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();

        //string myResume = resume._jobs[0]._company;
        //Console.WriteLine(myResume);


    }
}