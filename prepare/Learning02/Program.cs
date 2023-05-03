using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Customer Service Rep";
       job1._company = "Amazon";
       job1._startYear = "2016";
       job1._endYear = "2020";

       Job job2 = new Job();
       job2._jobTitle = "Tech Support Rep Ter 1";
       job2._company = "Asurion";
       job2._startYear = "2008";
       job2._endYear = "2016";

       Resume myResume = new Resume();
       myResume._name = "Rachael Hollinger";
       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       myResume.Display();


    }
}