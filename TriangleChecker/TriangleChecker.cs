Console.WriteLine("Let's determine what kind of triangle you have.");
Console.WriteLine("Please enter the length of the first side of the triangle");
int sideA = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the length of the second side of the triangle");
int sideB = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the length of the third side of the triangle");
int sideC = int.Parse(Console.ReadLine());
if ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA))
{
    if ((sideA == sideB) && (sideB == sideC))
    {
        Console.WriteLine("It's an equilateral triangle");
    }
    else if ((sideA == sideB) || (sideA == sideC) || (sideB == sideC))
    {
        Console.WriteLine("It's an isosceles triangle!");
    }
    else
    {
        Console.WriteLine("It's a scalene triangle!");
    }
}
else
{
    Console.WriteLine("That's not a triangle!");
}