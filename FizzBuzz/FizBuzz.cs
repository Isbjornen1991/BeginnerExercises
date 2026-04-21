//If it can be divided by 3, show fizz
//If it can be divded by 5, show buzz
//If it can be divided by both 3 and 5, show fizzbuzz

int GenerateNumber()
{
    return new Random().Next(1, 101);
}

bool play = true;

do
{
    play = false;
    Console.WriteLine("Do you want to generate a new number?");
    string playAgain = Console.ReadLine();
    play = playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase) || playAgain.Equals("Yes", StringComparison.OrdinalIgnoreCase);
    if (play == false)
    {
        break;
    }
   
    int GeneratedNumber = GenerateNumber();
    
    Console.WriteLine("The generated number is: " + GeneratedNumber + ".");
    
    if ((GeneratedNumber % 3 == 0) && (GeneratedNumber % 5 == 0)){
    Console.WriteLine("Fizzbuzz!");
}
    else if (GeneratedNumber % 3 == 0) {
    Console.WriteLine("Fizz!");
}
    else if (GeneratedNumber % 5 == 0) {
    Console.WriteLine("Buzz!");
}
    else {
    Console.WriteLine("Nah brah, this number neither fizzes nor buzzes!");
}

}   while (play == true);   