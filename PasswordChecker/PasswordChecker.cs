// See https://aka.ms/new-console-template for more information
string password = "coffee";
int attempts = 0;
bool success = false;

while (attempts <= 3 && success == false)
{
    //This makes it output the "Input password" every time the user enters an incorrect password. Might want to set up some logic later that makes it not do that.
    Console.WriteLine("Input password:");
    string input = Console.ReadLine();
    if (input == password)
    {
        success = true;
        attempts = 0;
        Console.WriteLine("Access Granted!");
    }
    else
    {
        attempts = attempts + 1;
        Console.WriteLine("Incorrect Password. Please try again.");
    }
    if (attempts > 3)
    {
        Console.WriteLine("Too many attempts. Please try again later or contact a system administrator.");
    }
}

