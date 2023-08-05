int[] givenArray = new int[] { 8, 5, 3, 3, 46, 123, 34, 97, 45, 3, 7, 2, 89, 9, 234, 4, 89, 4, 3, 26, 4, 22, 8, 0, 45, 2, 1 };

Console.WriteLine("Actual Array --> " + "{0}", string.Join(",", givenArray));

QuickSort(givenArray, 0, givenArray.Length - 1);

Console.WriteLine("Sorted Array --> " + "{0}", string.Join(",", givenArray));

Console.ReadLine();


void QuickSort(int[] array, int start, int end)
{
    if (start >= end)
        return;

    int p = Partition(array, start, end);
    QuickSort(array, start, p - 1);
    QuickSort(array, p + 1, end);
}

int Partition(int[] array, int start, int end)
{

    int pivot = array[end];
    int i = start - 1;

    for (int j = start; j < end; j++)
    {
        if (array[j] < pivot)
        {
            i++;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

    }

    int t = array[i + 1];
    array[i + 1] = array[end];
    array[end] = t;


    return i + 1;

}