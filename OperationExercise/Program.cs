// See https://aka.ms/new-console-template for more information


//int a = 17;
//int b = 4;


//int quotient = a / b;
//int remainder = a % b;
//if (a == 17 && b == 4)

// Console.WriteLine($"{a} /= {b} is {quotient} remainder of {remainder}");

using OperationExercise;

Console.WriteLine("What is the radius of your circle?");
var userInput = Console.ReadLine();
var radius = double.Parse(userInput);
Console.WriteLine(Exercise2.AreaOfCircle(radius));







