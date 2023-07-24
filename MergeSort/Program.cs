int[] givenArray = new int[] { 8, 5, 3, 3, 46, 123, 34, 97, 45, 3, 7, 2, 89, 9, 234, 4, 89, 4, 3, 26, 4, 22, 8, 0, 45, 2, 1 };

Console.WriteLine("Actual Array --> " + "{0}", string.Join(",", givenArray));

MergeSort(givenArray);

Console.WriteLine("Sorted Array --> " + "{0}", string.Join(",", givenArray));

Console.ReadLine();

void MergeSort(int[] array)
{
    if (array.Length > 1)
    {

        int middleIndex = array.Length / 2;


        #region Sub arrays are splitted
        int[] leftArray = new int[middleIndex];
        int[] rightArray = new int[array.Length - middleIndex];

        Array.Copy(array, 0, leftArray, 0, middleIndex);
        Array.Copy(array, middleIndex, rightArray, 0, array.Length - middleIndex);
        #endregion

        MergeSort(leftArray);
        MergeSort(rightArray);

        Merge(array, leftArray, rightArray); 

    }

}

void Merge(int[] array, int[] leftArray, int[] rightArray)
{
    int leftIndex = 0, rightIndex = 0, arrayIndex = 0;

    while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
    {
        if (rightArray[rightIndex] > leftArray[leftIndex])
        {
            array[arrayIndex] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            array[arrayIndex] = rightArray[rightIndex];
            rightIndex++;
        }
        arrayIndex++;
    }

    while (leftIndex < leftArray.Length)
    {
        array[arrayIndex] = leftArray[leftIndex];
        leftIndex++;
        arrayIndex++;
    }

    while (rightIndex < rightArray.Length)
    {
        array[arrayIndex] = rightArray[rightIndex];
        rightIndex++;
        arrayIndex++;
    }

}