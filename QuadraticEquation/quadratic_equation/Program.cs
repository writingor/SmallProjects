
using System.Text.RegularExpressions;


// ax^2 + bx + c = 0


string yesOrNo = "y";

while (yesOrNo == "y")
{

    Console.WriteLine($"Enter the coefficients of the quadratic equation ax^2 + bx + c = 0");
    Console.WriteLine($"!!! MAXIMUM TWO DIGIT NUMBER !!!");

    Console.WriteLine("What is 'a' equal to?");
    Console.Write("a = ");

    string aCoefficient = Console.ReadLine();
    aCoefficient = aCoefficient.Replace(" ", "");
    int aOut = 0;
    while (aOut == 0)
    {
        if (Regex.IsMatch(aCoefficient, @"^-?\d{1}(\d{1})?$"))
        {
            aOut = int.Parse(aCoefficient);
        }
        if (aOut < 1)
        {
            Console.WriteLine("'a' must be greater than 0");
            Console.Write("Try again: a = ");
            aCoefficient = Console.ReadLine();
        }


    }

    Console.WriteLine($"You: a = {aOut}");


    Console.WriteLine("What is 'b' equal to?");
    Console.Write("b = ");

    string bCoefficient = Console.ReadLine();
    bCoefficient = bCoefficient.Replace(" ", "");
    int bOut = 0;
    if (Regex.IsMatch(bCoefficient, @"^-?\d{1}(\d{1})?$"))
    {
        bOut = int.Parse(bCoefficient);
    }

    Console.WriteLine($"You: b = {bOut}");


    Console.WriteLine("What is 'c' equal to?");
    Console.Write("c = ");

    string cCoefficient = Console.ReadLine();
    cCoefficient = cCoefficient.Replace(" ", "");
    int cOut = 0;
    if (Regex.IsMatch(cCoefficient, @"^-?\d{1}(\d{1})?$"))
    {
        cOut = int.Parse(cCoefficient);
    }

    Console.WriteLine($"You: c = {cOut}");


    double discriminant = bOut * bOut - 4 * aOut * cOut;
    Console.WriteLine($"Discriminant = {discriminant}");

    if (discriminant < 0)
    {
        Console.WriteLine("The roots of the equation cannot be found.");
    }
    else
    {
        double firstRoot = (-bOut - Math.Sqrt(discriminant)) / 2 * aOut;
        double secondRoot = (-bOut + Math.Sqrt(discriminant)) / 2 * aOut;

        Console.WriteLine($"Roots: {firstRoot}, {secondRoot}");
    }


    Console.WriteLine("Do you want to try again?");
    Console.Write("Enter 'y' to try or 'n' to exit: ");
    yesOrNo = Console.ReadLine();
    yesOrNo = yesOrNo.Replace(" ", "");

    bool tmp = false; 
    if (yesOrNo == "y" || yesOrNo == "n")
    {
        tmp = true;
        Console.Clear();
    }
    while (tmp == false)
    {
        Console.WriteLine("Sorry, I didn't understand the answer.");
        Console.Write("Enter 'y' to try or 'n' to exit: ");
        yesOrNo = Console.ReadLine();
        if (yesOrNo == "y" || yesOrNo == "n")
        {
            tmp = true;
            Console.Clear();
        }
    }
    if (yesOrNo == "n")
    {
        break;
    }
}

