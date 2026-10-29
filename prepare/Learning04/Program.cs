using System;

class Program
{
    static void Main(string[] args)
    {
        Assingments myAssignment = new Assingments("Peter", "math");
        Console.WriteLine(myAssignment.GetSummary());
        Math myMath = new Math("Peter", "math", "6.7", "19-20");
        Console.WriteLine(myMath.GetHomeworkList());
        Writing myWriting = new Writing("Jacob", "Writing", "The greatness");
        Console.WriteLine(myWriting.GetWritingInformation());

    }
}