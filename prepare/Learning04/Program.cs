using System;

class Program
{
    static void Main(string[] args)
    {
       
       Assignment assignment1 = new Assignment();
       assignment1.setStudentName("Samual Bennett");
       assignment1.setTopic("Multiplication");
       Console.WriteLine(assignment1.getSummary());

       MathAssignment assignment2 = new MathAssignment();
       assignment2.setStudentName("Roberto Rodriguez");
       assignment2.setTopic("Fractions");
       assignment2.setTextbookSection("7.3");
       assignment2.setProblems("8-19");
       Console.WriteLine(assignment2.getSummary());
       Console.WriteLine(assignment2.getHomeworkList());

       WritingAssignment assignment3 = new WritingAssignment();
       assignment3.setStudentName("Mary Waters");
       assignment3.setTopic("European History");
       assignment3.setTitle("The Causes of World War II");
       Console.WriteLine(assignment3.getSummary());
       Console.WriteLine(assignment3.getWritingInformation());

    }
}