using System.Net.Http.Headers;
using System.Text;

//Parantheses Generation

// 1-> Every open bracket '(' must be closed by a corresponding closing bracket ")".
// 2-> The parentheses must be correctly nested and balanced, meaning that every open bracket
// has a corresponding closing bracket that is not preceded by another closing bracket without a matching opening bracket.

string leftBracket = "(";
string rightBracket = ")";
int numberOfLeftBracket;
int numberOfRightBracket;


Console.Write("Number of parentheses: ");
int numberOfParantheses = Convert.ToInt32(Console.ReadLine());

// Parantheses length must be an even number.
Console.Write("Length of parentheses: "); 
int lengthOfParantheses = Convert.ToInt32(Console.ReadLine());


Execute();

void Execute()
{

    if (lengthOfParantheses % 2 != 0)
    {
        Console.WriteLine("Please write an even number for the length!");
        Console.Write("Length of parentheses: ");
        lengthOfParantheses = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < numberOfParantheses; i++)
    {
        if (i < 9)
            Console.WriteLine("0{0} => {1}", i + 1, GenerateParantheses());
        else
            Console.WriteLine("{0} => {1}", i + 1, GenerateParantheses());
    }
    Console.ReadLine();
}

string GenerateParantheses()
{
    StringBuilder paranthesesString = new StringBuilder();
    paranthesesString.Append(leftBracket); // Appended left bracket in order not to break to rule

    int paranthesesLength = lengthOfParantheses - 1;

    for (int i = 0; i < paranthesesLength; i++)
    {
        string currentBracket = RandomBracket();
        if (currentBracket == leftBracket)
            paranthesesString = (FindCurrentLeftBracket(paranthesesString) - FindCurrentRightBracket(paranthesesString)) > paranthesesLength - i - 1 ? paranthesesString.Append(rightBracket) : paranthesesString.Append(currentBracket);
        else if (currentBracket == rightBracket)
            paranthesesString = FindCurrentRightBracket(paranthesesString) == FindCurrentLeftBracket(paranthesesString) ? paranthesesString.Append(leftBracket) : paranthesesString.Append(currentBracket);
    }
    return paranthesesString.ToString();
}


string RandomBracket()
{
    if (new Random().Next(1, 10) > 5)
        return leftBracket;
    else
        return rightBracket;
}


int FindCurrentLeftBracket(StringBuilder stringBuilder)
{
    numberOfLeftBracket = 0;

    for (int i = 0; i < stringBuilder.Length; i++)
    {
        if (stringBuilder.ToString(i, 1) == "(")
            numberOfLeftBracket++;
    }
    return numberOfLeftBracket;
}


int FindCurrentRightBracket(StringBuilder stringBuilder)
{
    numberOfRightBracket = 0;

    for (int i = 0; i < stringBuilder.Length; i++)
    {
        if (stringBuilder.ToString(i, 1) == ")")
            numberOfRightBracket++;
    }
    return numberOfRightBracket;
}




