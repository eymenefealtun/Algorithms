int[] _givenArray = new int[] { 45, 2, 7, 23, 457, 36, 46, 3, 136, 63, 263, 1268, 57, 73, 2, 64, 6, 2, 6, 35, 4, 711, 83, 468, 7, 65, 3456, 234, 6, 1 };

Console.WriteLine("Actual Array --> " + "{0}", string.Join(",", _givenArray));

RaxisSort(_givenArray);

Console.WriteLine("Sorted Array --> " + "{0}", string.Join(",", _givenArray));

Console.ReadLine();

void RaxisSort(int[] givenArray)
{
    int digitsNumberOfMaximumNumber = givenArray.Max().ToString().Length;

    for (int j = 0; j < digitsNumberOfMaximumNumber; j++) // sorting process for every digit of maximum number in the array
        while (!ArrayDone(givenArray, j)) // check if array sorted for the exact digit
            for (int i = 0; i < givenArray.Length - 1; i++) // swapping 
                if (GetDigit(givenArray[i], j) > GetDigit(givenArray[i + 1], j) || GetDigit(givenArray[i], j) != null && GetDigit(givenArray[i + 1], j) == null)
                {
                    int current = givenArray[i];
                    givenArray[i] = givenArray[i + 1];
                    givenArray[i + 1] = current;
                }
}

bool ArrayDone(int[] array, int currentIndex)
{
    for (int i = 0; i < array.Length - 1; i++)
        if (GetDigit(array[i], currentIndex) > GetDigit(array[i + 1], currentIndex) || GetDigit(array[i], currentIndex) != null && GetDigit(array[i + 1], currentIndex) == null)
            return false;
    return true;
}

int? GetDigit(int number, int desiredIndex)
{
    if (desiredIndex >= number.ToString().Length)
        return null;
    return Convert.ToInt32(number.ToString().Substring(number.ToString().Length - 1 - desiredIndex, 1));
}