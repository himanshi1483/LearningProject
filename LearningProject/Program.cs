// See https://aka.ms/new-console-template for more information
using LearningProject;


string s = "Hello Extension Methods";
int i = s.WordCount();
Console.WriteLine("Word Count:", i);

// Pattern Matching: technique where you test an expression to determine if it has certain characteristics.
// The "is expression" supports pattern matching to test an expression and conditionally declare a new variable to the result of that expression.
// The "switch expression" enables you to perform actions based on the first matching pattern for an expression.
int? maybe = 12;

if (maybe is int number)
{
    Console.WriteLine($"The nullable int 'maybe' has the value {number}");
}
else
{
    Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
}

string? message = "This is not the null string";

if (message is not null)
{
    Console.WriteLine(message);
}


// Discards: placeholder variables that are intentionally unused in application code.
// Discards are equivalent to unassigned variables; they don't have a value.
// A discard indicates that our code never uses the variable. They enhance its readability and maintainability.

//(_, _, area) = city.GetCityInformation(cityName);
