using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
    Console.WriteLine("##################################################");
    Console.WriteLine("Result Processing System");
     Console.WriteLine("By Philcz");
    Console.WriteLine("##################################################");
     Console.WriteLine("Enter your name!");
      Console.WriteLine("-------------------------------------------------------");
     var name = Console.ReadLine();
      Console.WriteLine($"Welcome {name}!");
       Console.WriteLine("-------------------------------------------------------");
       Console.WriteLine("Enter the number of scores");
       var number_score = Convert.ToDouble(Console.ReadLine());
List<double> grades = new List<double>();
var result = 0.0;
    for (int i=1; i<=number_score;i++){
        Console.WriteLine($"Enter score {i}");
        var score = Convert.ToDouble(Console.ReadLine());
        grades.Add(score);
    }
    foreach (var grade in grades){
        result +=grade;
    }
      result /= grades.Capacity;
      Console.WriteLine($"The average of your score is {result}");
        }
    }
}