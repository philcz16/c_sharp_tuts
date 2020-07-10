using System;
using System.Collections.Generic;

class max_min
{
    public void max_min_grade(){

var numbers = new List<double> (){12.5,7.8,134.6,43.6,43.5,14.7};
var max_number = double.MinValue;
var min_number = double.MaxValue;
foreach(var number in numbers){
 max_number = Math.Max(number, max_number);
 min_number = Math.Min(number, min_number);
}
Console.WriteLine($"The Maximum number is: {max_number}");
Console.WriteLine($"The Minimum number is: {min_number}");
    }
    List<double> numbers;
}