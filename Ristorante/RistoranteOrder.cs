//int pizza = 0;
//int pancakes = 1;
//int pasta = 2;

Console.WriteLine("Welcome to Luigi's! Please press the number for the dish you would like to order. Press 1 for Pizza. Press 2 for Pancakes. Press'a the 3 for pasta!");
int order;
Int32.TryParse(Console.ReadLine(), out order);
order = order - 1;
while ((order <= -1) || (order >= 3))
{
    Console.WriteLine("Incorrect input Please try again!");
    Int32.TryParse(Console.ReadLine(), out order);
    order = order - 1;
}
if  (order == 0)
{
    Console.WriteLine("I bringa tha pizza!");
}
if (order == 1)
{
    Console.WriteLine("I bringa tha pancakes!");
}
if (order == 2)
{
    Console.WriteLine("I bringa tha pasta!");
}