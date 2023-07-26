int[] _givenArray = CreateRandomArray(20, 0, 1000);

Console.WriteLine("Actual Array --> " + "{0}", string.Join(",", _givenArray));

SelectionSort(_givenArray);

Console.WriteLine("Sorted Array --> " + "{0}", string.Join(",", _givenArray));

Console.ReadLine();

void SelectionSort(in int[] givenArray)
{

    for (int i = 0; i < givenArray.Length - 1; i++)
    {
        int minimumIndex = i;

        for (int j = i + 1; j < givenArray.Length; j++)
            if (givenArray[minimumIndex] > givenArray[j])
                minimumIndex = j;


        int currentNumber = givenArray[i];

        givenArray[i] = givenArray[minimumIndex];
        givenArray[minimumIndex] = currentNumber;

    }

}

int[] CreateRandomArray(int numberOfItems, int minValue, int maxValue)
{
    int[] _givenArray = new int[numberOfItems];

    Random random = new Random();

    for (int i = 0; i < numberOfItems; i++)
        _givenArray[i] = random.Next(minValue, maxValue);

    return _givenArray;
}