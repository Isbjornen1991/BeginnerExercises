//bool fromChosen = false;
bool fromC = false;
bool fromF = false;
bool fromK = false;

//Ask user what unit they want to convert from.

do {
    Console.WriteLine("Welcome to the temperature converter. Please enter which unit of measurement you would like to convert from.");
    Console.WriteLine("Enter C, F or K");

    string inputFrom = Console.ReadLine();
    string inputFromCleaned = inputFrom.ToUpper();

    if (inputFromCleaned == "C")
    {
        fromC = true;
        //fromChosen = true;
        Console.WriteLine("You've chosen to convert from Celsius.");
    }

    else if (inputFromCleaned == "F")
    {
        fromF = true;
        //fromChosen = true;
        Console.WriteLine("You've chosen to convert from Fahrenheit.");
    }

    else if (inputFromCleaned == "K")
    {
        fromK = true;
        //fromChosen = true;
        Console.WriteLine("You've chosen to convert from Kelvin.");
    }

    else
    {
        Console.WriteLine("Incorrect format. Please try again.");
    }
 }
while (!fromC && !fromF && !fromK);

//bool toChosen = false;
bool toC = false;
bool toF = false;
bool toK = false;

//Ask the user what unit they want to convert to.

do
{
    Console.WriteLine("Please enter which unit of measurement you would like to convert to.");
    Console.WriteLine("Enter C, F or K");

    string inputTo = Console.ReadLine();
    string inputToCleaned = inputTo.ToUpper();

    if ((inputToCleaned == "C") && (toC != true))
    {
        toC = true;
        //toChosen = true;
        Console.WriteLine("You've chosen to convert to Celsius.");
    }

    else if (inputToCleaned == "F" && (toF != true))
    {
        toF = true;
        //toChosen = true;
        Console.WriteLine("You've chosen to convert to Fahrenheit.");
    }

    else if (inputToCleaned == "K" && (toK != true))
    {
        toK = true;
        //toChosen = true;
        Console.WriteLine("You've chosen to convert to Kelvin.");
    }

    else
    {
        Console.WriteLine("Incorrect format or same unit chosen. Please try again.");
    }
}
while (!toC && !toF && !toK);

bool validTemp = false;
float temperature = 0;

//Ask the user how many degrees they want to convert.

do
{
    Console.WriteLine("Enter how many degrees you want to convert from.");

    validTemp = float.TryParse(Console.ReadLine(), out temperature);

    if (validTemp == true)
    {
        Console.WriteLine("You entered " + temperature + " degrees");
    }
    else
    {
        Console.WriteLine("Invalid temperature format. Please enter a number.");
    }
}
while (validTemp == false);

float outTemp = 0;
char outUnit = '\0';

//From C to F

if (fromC == true && toF == true)
{
    outTemp = (temperature * 1.8F) + 32F;
    outUnit = 'F';
}

//From C to K

if (fromC == true && toK == true)
{
    outTemp = (temperature + 273.15F);
    outUnit = 'K';

}

//From F to C

if (fromF == true && toC == true)
{
    outTemp = (temperature - 32F) / 1.8F;
    outUnit = 'C';
}

//From F to K

if ((fromF == true) && (toK == true))
{
    outTemp = (temperature - 32F) / 1.8F + 273.15F;
    outUnit = 'K';
}

//From K to C

if ((fromK == true ) && (toC == true))
{
    outTemp = temperature - 273.15F;
    outUnit = 'C';
}

//From K to F

if ((fromK == true) && (toF == true))
{
    outTemp = ((temperature - 273.15F) * 1.8F) + 32F;
    outUnit = 'F';
}

//Final Output Check
//Absolute lowest temperatures are: 0 K, -273,15 C, -459.67 F

if (((outTemp < 0F) && toK == true) || 
    ((outTemp < -273.15F) && toC == true) || 
    ((outTemp < -459.67F) && toF == true))
{
    Console.WriteLine("Entered temperature is below absolute zero, and is therefore invalid.");
}
else
{
    Console.WriteLine("The converted temperature is " + outTemp + "°" + outUnit + ".");
}