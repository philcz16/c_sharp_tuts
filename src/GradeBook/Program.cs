using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("###########################################");
        Console.WriteLine("Welcome to Result Processing System!!!");
        Console.WriteLine("By Philcz");
        Console.WriteLine("###########################################");
        Console.WriteLine("----------------------------------------------------------------------------------------");
        Console.WriteLine("Enter your name!");
         var name = Console.ReadLine();
        Console.WriteLine($"Welcome {name} ");
        Console.WriteLine("----------------------------------------------------------------------------------------");
        Console.WriteLine("Enter number of grades");
        var grade_num = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter grades");
          List<double> grades = new List<double>();
          for (int i=1; i<=grade_num;i++){
              Console.WriteLine($"Enter score {i}:");
              var score = Convert.ToDouble(Console.ReadLine());
              grades.Add(score);

        double result = 0.0;
          foreach(var number in grades){
             result += number;
          }
          result /= grades.Count;
         Console.WriteLine($"The average score is {result}");
        }
    }
}
 