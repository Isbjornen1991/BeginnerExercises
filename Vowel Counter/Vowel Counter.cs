Console.WriteLine("Write your word to count vowels in.");
string word = Console.ReadLine();
int count = 0;
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
for (int character = 0; character < word.Length; character++)
{
    char lowerCaseChar = char.ToLower(word[character]);

    if (vowels.Contains(lowerCaseChar))
        { count++; }
}
Console.WriteLine("The amount of vowels is " + count + ".");
