List<int> sortedList = new List<int>{};
List<int> firstList = new List<int> { 2, 4, 6, 8 };
List<int> secondList = new List<int> { 1, 3, 5, 7, 9 };
//int firstListPos = 0;
//int secondListPos = 0;
sortedList.AddRange(firstList);
sortedList.AddRange(secondList);

sortedList.Sort();

foreach (int number in sortedList)
{
    Console.WriteLine(number);
}