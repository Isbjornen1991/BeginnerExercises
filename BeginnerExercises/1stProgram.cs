// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("It works!");
Console.WriteLine("Hi! I'm HAL2000! What's your name?");
string? name = Console.ReadLine();
Console.WriteLine("Hello, " + name);
Console.WriteLine("How old are you " + name + "?");
int age;
Int32.TryParse(Console.ReadLine(), out age);
if (age >= 40)
{
    Console.WriteLine("Oh wow! That old huh?");
}
else
{ 
    Console.WriteLine("Shouldn't you be in school?"); 
}

