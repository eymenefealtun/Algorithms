int[] _givenArray = new int[] { 99, 56, 334, 24, 7, 678, 4, 3, 2, 8, 8, 7, 3, 2, 45, 4, 2, 8, 3, 23, 6, 234, 24, 8, -43, 9, 469, 6, 7, 357, 49, 4, 68, 357, 2247, 3584, 7, 9, 11 };

Console.WriteLine("Given array: " + String.Join(',', _givenArray));
CocktailSort(_givenArray);
Console.WriteLine("Sorted array: " + String.Join(',', _givenArray));

Console.ReadLine();

void CocktailSort(int[] givenArray)
{
    //Biggest value transfered to end of array
    for (int i = 0; i < givenArray.Length - 1; i++)
    {
        if (givenArray[i] <= givenArray[i + 1])
            continue;

        int currentValue = givenArray[i];
        givenArray[i] = givenArray[i + 1];
        givenArray[i + 1] = currentValue;
    }

    //Smallest value transfered to beginning of array       
    for (int i = givenArray.Length - 1; i > 0; i--)
    {
        if (givenArray[i] >= givenArray[i - 1])
            continue;

        int currentValue = givenArray[i];
        givenArray[i] = givenArray[i - 1];
        givenArray[i - 1] = currentValue;
    }

    //recursive call
    if (!IsArrayDone(givenArray))
        CocktailSort(givenArray);
}

bool IsArrayDone(int[] givenArray)
{
    for (int i = 0; i < givenArray.Length - 1; i++)
        if (givenArray[i] > givenArray[i + 1])
            return false;

    return true;
}