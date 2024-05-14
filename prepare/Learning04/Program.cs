using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment();
        student1.SetStudentName ("Samuel Bennett");
        student1.SetTopic ("Multiplication");

        Console.WriteLine();
        Console.WriteLine(student1.GetSummary());

        MathAssignment student2 = new MathAssignment();
        student2.SetStudentName("Roberto Rodriguez");
        student2.SetTopic("Fractions");
        student2.SetSection("7.3");
        student2.SetProblems("8-19");

        Console.WriteLine();
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());

        WritingAssignment student3 = new WritingAssignment();
        student3.SetStudentName("Mary Waters");
        student3.SetTopic("European History");
        student3.SetTitle("The Causes of World War II");

        Console.WriteLine();
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());

        // WritingAssignment student5 = new WritingAssignment();
        // Console.WriteLine();
        // Console.WriteLine(student5.GetSummary());

        // WritingAssignment.student6 = new WritingAssignment("Smith", "Religion", "The Book of Mormon");
        // Console.WriteLine();
        // Console.WriteLine(student3.GetSummary());
        // Console.WriteLine(student3.GetWritingInformation());

    }
}