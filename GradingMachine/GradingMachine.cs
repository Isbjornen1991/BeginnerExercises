Console.WriteLine("Insert student points from their assignment");
int points = int.Parse (Console.ReadLine());
if  (points >= 90)
{
    if (points >= 97)
    {
        Console.WriteLine("A+");
    }

    else if (points >= 93) {
        Console.WriteLine("A");
    }
    else Console.WriteLine("A-");
}
else if (points >= 80)
{
    if (points >= 87)
    {
        Console.WriteLine("B+");
    }

    else if (points >= 83)
    {
        Console.WriteLine("B");
    }
    else Console.WriteLine("B-");
}
else if (points >= 70)
{
    if (points >= 77)
    {
        Console.WriteLine("C+");
    }

    else if (points >= 73)
    {
        Console.WriteLine("C");
    }
    else Console.WriteLine("C-");
}
else
{
    Console.WriteLine("This is Asian grading! STUDENT FAILs WITH SO FEW POINTS!");
}