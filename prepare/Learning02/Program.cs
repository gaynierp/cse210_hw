using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Cybersecurity";
        Resume MyResume = new Resume();
        MyResume._name = "Peter";
        MyResume._jobList.Add(job1);
        MyResume.DisplayResume();



    }
}