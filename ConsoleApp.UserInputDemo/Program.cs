//Declare variables
using System.Xml.Linq;

string FirstName = string.Empty;
string LastName = string.Empty;

int age = 0;
int RetirementAge = 65;

//Prompt the user for input
Console.WriteLine("Please enter your first name.");
FirstName = Console.ReadLine();

Console.WriteLine("Please enter your last name.");
LastName = Console.ReadLine();

Console.WriteLine("Please enter your age.");
//string initiaAgeValue = Console.ReadLine();
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = RetirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {FirstName} {LastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");


