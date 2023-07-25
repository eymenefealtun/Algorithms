using System.Runtime.CompilerServices;

int[] _givenArray = new int[] { 8, 5, 3, 3, 46, 123, 34, 97, 45, 3, 7, 2, 89, 9, 234, 4, 89, 4, 3, 26, 4, 22, 8, 0, 45, 2, 1 };

Console.WriteLine("Actual Array --> " + "{0}", string.Join(",", _givenArray));

InsertionSort(_givenArray);

Console.WriteLine("Sorted Array --> " + "{0}", string.Join(",", _givenArray));

Console.ReadLine();


void InsertionSort(int[] givenArray)
{

    for (int i = 0; i < givenArray.Length - 1; i++)
    {
        int currentValue = givenArray[i];

        if (givenArray[i] > givenArray[i + 1])
        {
            givenArray[i] = givenArray[i + 1];
            givenArray[i + 1] = currentValue;
        }

        CheckLeftOvers(i, givenArray);
    }

}
            

void CheckLeftOvers(int index, int[] array)
{

    for (int i = index; i > 0; i--)
    {
        int currentValue = array[i];

        if (array[i] < array[i - 1])
        {
            array[i] = array[i - 1];
            array[i - 1] = currentValue;
        }
        else
            break;
    }

}