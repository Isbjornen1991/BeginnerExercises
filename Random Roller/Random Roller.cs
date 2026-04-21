using System.Security.Cryptography;

int count = 0;
bool play = true;
Console.WriteLine("Rolling dice!");
while ((count < 21) && play == true)
{
    Console.WriteLine("Do you want to keep rolling?");
    string playAgain = Console.ReadLine();
    play = playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase) || playAgain.Equals("Yes", StringComparison.OrdinalIgnoreCase);

    Random rng= new Random();
    int roll = rng.Next(1, 7);
    Console.WriteLine("It rolled " + roll + ".");
    count = count + roll;
    Console.WriteLine("Count is at " + count +".");
}
if (count >= 21)
{
    Console.WriteLine("Count ended at " + count + ".");
}

//This would need some logic for stopping when you say no I dont want to roll more. Now it rolls once and quits when you say no.