int[] _givenArray = new int[] { 45, 2, 7, 23, 457, 36, 46, -3, 136, 63, 263, -97893288, -57, 73, 2, 64, 6, 2, 6, 35, 4, -711, 83, 468, 7, 65, 3456, 234, -6, 1 };

Console.WriteLine("Actual Array --> " + "{0}", string.Join(",", _givenArray));

RaxisSort(_givenArray);

Console.WriteLine("Sorted Array --> " + "{0}", string.Join(",", _givenArray));

Console.ReadLine();

void RaxisSort(int[] givenArray)
{
    int digitsNumberOfLargestNumber = Math.Abs(givenArray.Max()) > Math.Abs(givenArray.Min()) ? givenArray.Max().ToString().Length : givenArray.Min().ToString().Length - 1;

    for (int j = 0; j < digitsNumberOfLargestNumber; j++) // sorting process for every digit of maximum number in the array
        while (!ArrayDone(givenArray, j)) // check if array sorted for the exact digit
            for (int i = 0; i < givenArray.Length - 1; i++)// swapping 
            {
                int? left = GetDigit(givenArray[i], j);
                int? right = GetDigit(givenArray[i + 1], j);

                if (left > right || (left != null && right == null && left >= 0) || (left == null && right < 0))
                {
                    int current = givenArray[i];
                    givenArray[i] = givenArray[i + 1];
                    givenArray[i + 1] = current;
                }

            }
}

bool ArrayDone(int[] array, int currentIndex)
{
    for (int i = 0; i < array.Length - 1; i++)
        if (GetDigit(array[i], currentIndex) > GetDigit(array[i + 1], currentIndex) || (GetDigit(array[i], currentIndex) != null && GetDigit(array[i + 1], currentIndex) == null && GetDigit(array[i], currentIndex) >= 0) || (GetDigit(array[i], currentIndex) == null && GetDigit(array[i + 1], currentIndex) < 0))
            return false;
    return true;
}

int? GetDigit(int number, int desiredIndex)
{
    if (number < 0)
        return desiredIndex >= number.ToString().Length - 1 ? null : Convert.ToInt32(number.ToString().Substring(number.ToString().Length - 2 - desiredIndex, 2));
    else
        return desiredIndex >= number.ToString().Length ? null : Convert.ToInt32(number.ToString().Substring(number.ToString().Length - 1 - desiredIndex, 1));

}