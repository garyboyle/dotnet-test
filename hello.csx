#!/usr/bin/env dotnet-script

var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
var result = 0.0;

foreach (var number in grades)
{
  result += number;
}

Console.WriteLine(result / grades.Count)
