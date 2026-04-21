int GenerateNumber()
{
    return new Random().Next(1, 101);
}

int first = GenerateNumber();
int second = GenerateNumber();

Console.WriteLine(first);
Console.WriteLine(second);

int Add (int a, int b)
{
    int c = a + b;
    return c; 
}

int output = Add(first, second);

Console.WriteLine(output);
