List<int> randomNumbers = new List<int>();

int GenerateNumber()
{
    return new Random().Next(1, 101);
}

for (int i = 0;i < 10; i++)
{
    int generatedNumber = GenerateNumber();
    randomNumbers.Add(generatedNumber);
}

Console.WriteLine("This is your randomly generated array:");

foreach (int number in randomNumbers)
{
    Console.WriteLine(number);
}

int count = 0;

for (int i = 0; i <= randomNumbers.Count-1; i++)
{
    bool swapped = false;
    count ++;

    for (int j = 0; j < randomNumbers.Count-1; j++)
    {
        if (randomNumbers[j] > randomNumbers[j+1])
        {
            int temp = randomNumbers[j];
            randomNumbers[j] = randomNumbers[j+1];
            randomNumbers[j+1] = temp;      
            
            swapped = true;  
        }
    }
    if (!swapped)
    {
        break;
    }
}
Console.WriteLine("This is your sorted array:");

foreach (int number in randomNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("The amount of iterations was:");
Console.WriteLine(count);