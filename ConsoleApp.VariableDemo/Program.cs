// See https://aka.ms/new-console-template for more information

// Different Datatypes
/*
    Text - String
    Integer - Int
    Decimal - Float, Decimal, Double
    Logical - Bool (true, false)
    Date - datetime***
*/

String name = "Tona";

Console.WriteLine(name);
Console.WriteLine(" I am " + name); //String concatenation
Console.WriteLine($"{name} loves singing."); //String interpolation
Console.WriteLine(" Who is a Web administrator? {0}", name); // Formatted String

int Age  = 23;
int retirementYearsLeft = 42;
int retirementAge = Age + retirementYearsLeft;

Console.WriteLine("I am {0},", Age);
Console.WriteLine("My age is: " + Age);
Console.WriteLine("My retirment age is: " + retirementAge);

bool isRetired  = false;
Console.WriteLine("Am I retired? " + isRetired);