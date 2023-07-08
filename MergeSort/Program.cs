int[] array = new int[] { 1130, 925, 251, 299, 55, 553, 1415, 1014, 1339, 1239, 644, 636, 763, 341, 126, 597, 1338, 425, 993, 298, 276, 1305, 335, 847, 1242, 394, 67, 1476, 1098, 532, 453, 768, 550, 271, 1385, 1322, 952, 1259, 80, 131, 306, 755, 339, 305, 571, 147, 317, 1103, 951 };

int length = array.Length;

bool _isFirstPartDone = true;
bool _isSecondtPartDone = true;


Console.WriteLine("Actual Array --> " + "{0}", string.Join(",", array));

SortMerge(array);

Console.WriteLine("Sorted Array --> " + "{0}", string.Join(",", array));
Console.ReadLine();


void SortMerge(int[] numbers)
{
    while (!IsArrayDone(1))
    {
        for (int i = 0; i < length - 1; i++)
        {
            if (i <= length / 2)
            {
                int numberPlusOne = array[i + 1];
                int currentNumber = array[i];

                if (_isFirstPartDone)
                {
                    if (currentNumber > numberPlusOne)
                    {
                        array[i] = numberPlusOne;
                        array[i + 1] = currentNumber;
                    }
                    i++;
                }

                else if (currentNumber > numberPlusOne)
                {
                    array[i] = numberPlusOne;
                    array[i + 1] = currentNumber;
                }
            }
        }
        _isFirstPartDone = false;
    }

    while (!IsArrayDone(2))
    {
        for (int i = 0; i < length - 1; i++)
        {
            int numberPlusOne = array[i + 1];
            int currentNumber = array[i];
            if (i > length / 2)
            {
                if (_isSecondtPartDone)
                {

                    if (currentNumber > numberPlusOne)
                    {
                        array[i] = numberPlusOne;
                        array[i + 1] = currentNumber;
                    }
                    i++;
                }


                else if (currentNumber > numberPlusOne)
                {
                    array[i] = numberPlusOne;
                    array[i + 1] = currentNumber;
                }
            }
        }

        _isSecondtPartDone = false;
    }

    while (!IsArrayDone(0))
    {
        for (int i = 0; i < length - 1; i++)
        {
            int numberPlusOne = array[i + 1];
            int currentNumber = array[i];
            if (currentNumber > numberPlusOne)
            {
                array[i] = numberPlusOne;
                array[i + 1] = currentNumber;
            }
        }
    }

}

bool IsArrayDone(int? tr)
{
    if (tr == 0)
    {
        bool isDone = true;
        for (int i = 0; i <= length - 2; i++)
        {
            if (array[i] > array[i + 1])
                isDone = false;
        }
        return isDone;
    }

    else if (tr == 1)
    {
        bool isDone = true;
        for (int i = 0; i <= length - 2; i++)
        {
            if (array[i] > array[i + 1] && i <= length / 2)
                isDone = false;
        }
        return isDone;
    }

    else
    {
        bool isDone = true;
        for (int i = 0; i <= length - 2; i++)
        {
            if (array[i] > array[i + 1] && i > length / 2)
                isDone = false;
        }
        return isDone;
    }

}