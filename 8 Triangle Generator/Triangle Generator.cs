Console.WriteLine("How many rows long do you want your triangle to be?");
int length;
Int32.TryParse(Console.ReadLine(), out length);
for (int row = 0; row < length; row++)
{
    for (int col = 0; col < row+1; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
//Console.Write and Console.WriteLine are the interesting bits here. Note how .write keeps it on the same line.