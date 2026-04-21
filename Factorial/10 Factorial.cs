using System.Runtime.InteropServices;

Console.WriteLine("Input your factorial number.");
int input;
Int32.TryParse(Console.ReadLine(), out input);
int output = 1;
for (int calc = 1; calc <= input; calc++)
{
    output = output * calc;
    Console.WriteLine(output);
}
