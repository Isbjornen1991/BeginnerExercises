Console.WriteLine("Hello, I'm going to think of a number. You try guessing it. I'll let you know if it's lower or higher!");
string playAgain = "";
do
{
    int reply = -1;
    bool solved = false;
    int answer = new Random().Next(101);
    int attempts = 0;

    while ((solved == false))
    {
        Console.WriteLine("Write your guess!");
        Int32.TryParse(Console.ReadLine(), out reply);
        if (answer < reply)
        {
            Console.WriteLine("Nope, sorry!. It's lower!");
            attempts ++;
        }
        if (answer > reply)
        {
            Console.WriteLine("Afraid not, it's actually higher!");
            attempts++;
        }
        if (answer == reply)
        {
            solved = true;
            attempts++;
            Console.WriteLine("Yes! That's it. You guessed it. It took " + attempts + " attempts.");
            attempts = 0;
        }

    }
    Console.WriteLine("Would you like to play again? Type Y/Yes to restart.");
    playAgain = Console.ReadLine();

}
while (playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase) || playAgain.Equals("Yes", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Thanks for playing! Have a good one!");