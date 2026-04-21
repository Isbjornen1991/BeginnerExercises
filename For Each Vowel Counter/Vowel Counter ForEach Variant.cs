Console.WriteLine("Write your word to count vowels in.");
string word = Console.ReadLine();
int count = 0;
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

foreach (char character in word)
{
    char lowerCaseChar = char.ToLower(character);
    if (vowels.Contains(lowerCaseChar))
    count++;
}
Console.WriteLine("The amount of vowels is " + count + ".");
