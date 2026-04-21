using System.Drawing;

char[] container = ['a', 'n', 'n', 'a'];
int containerPos = container.Length-1;
int invContainerPos = 0;
char[] invertedContainer = new char[container.Length];
bool palindrome = true;
//Here we build the inverted array
while ((containerPos >= 0) && (invContainerPos <= container.Length - 1))
{
    invertedContainer[invContainerPos] = container[containerPos];
    containerPos = containerPos - 1;
    invContainerPos = invContainerPos + 1;
}
//Comparing the two comes here
//What I tried first(It was wrong):
//for (int pos = 0; invertedContainer[pos])
for (int pos = 0; pos < container.Length; pos++)
    //from     //to
{
    if (container[pos] != invertedContainer[pos])
    {
        palindrome = false;
        break;
        //What break does: If you find even one position where the characters don’t match,
        //then it’s already proven that the word is not a palindrome.
        //There’s no point checking the remaining positions.
    }
}
Console.WriteLine("It is " + palindrome);