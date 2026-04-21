Console.WriteLine("Welcome to the calculator.");

//Variables
bool exit = false;
double result = 0;

//Functions for Math
//Addition
double Add(double a, double b)
    {
    return a + b;   
}
//Subtraction
double Sub(double a, double b)
{
    return a - b;
}
//Multiplication
double Mult(double a, double b)
{
    return a * b;
}
//Division
double Div(double a, double b)
{
    return a / b;
}

//Primary Loop


    double firstnumber;
    double secondnumber;
    double tempresult = 0;
    string? operation = null;

    Console.WriteLine("Please enter your number.");
    double.TryParse(Console.ReadLine(), out firstnumber);
while (exit == false)
{
    Console.WriteLine("What operation would you like to run?");
    bool validoperation = false;
    while (validoperation == false)
    {
        operation = Console.ReadLine().Trim().ToLower();

        if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "add" || operation == "sub" || operation == "subtract" || operation == "mult" || operation == "multiply" || operation == "div" || operation == "divide" )
            {
            validoperation = true;
        }
        else
        {
            Console.WriteLine("Incorrect input. Please try again.");
        }
    }

    Console.WriteLine("Please enter your next number.");
    double.TryParse(Console.ReadLine(), out secondnumber);

    if (operation != null) 
    {
        switch (operation)
        {
            case "+":
            case "add":
            case "addition":
                tempresult = Add(firstnumber, secondnumber);
                result = tempresult;
                break;

            case "-":
            case "sub":
            case "subtract":
                tempresult = Sub(firstnumber, secondnumber);
                result = tempresult;
                break;
            case "*":
            case "multiply":
            case "mult":
                tempresult = Mult(firstnumber, secondnumber);
                result = tempresult;
                break;
            case "/":
            case "div":
            case "divide":
                if (secondnumber != 0)
                {
                    tempresult = Div(firstnumber, secondnumber);
                    result = tempresult;
                }
                else
                {
                    Console.WriteLine("Division by zero is impossible.");
                }
                break;
        }
    }

    firstnumber = tempresult;
    Console.WriteLine("Are you done inputting numbers?");
    string done = Console.ReadLine().Trim().ToLower();
    if (done == "y" || done == "yes" || done == "exit" || done == "quit")
    {
        exit = true;
    }
    Console.WriteLine("The sum so far is " + tempresult + ".");
}
Console.Write("The final sum is:");
Console.WriteLine(result);