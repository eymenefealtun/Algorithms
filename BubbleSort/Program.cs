int[] numbers = new int[] { 1130, 925, 251, 299, 55, 553, 1415, 231, 1014, 1339, 1239, 644, 636, 763, 341, 126, 597, 1338, 425, 993, 298, 276, 1305, 335, 847, 1242, 394, 67, 1476, 1098, 532, 453, 768, 550, 271, 1385, 1322, 952, 1259, 80, 131, 306, 755, 339, 305, 571, 147, 317, 1103, 951 };
Console.WriteLine("Actual Array --> " + "{0}", string.Join(",", numbers));

do
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int currentNumberPlusOne = numbers[i + 1];
        if (numbers[i] > numbers[i + 1])
        {
            numbers[i + 1] = numbers[i];
            numbers[i] = currentNumberPlusOne;
        }
    }           

} while (!IsArrayDone());           


Console.WriteLine();
Console.WriteLine("Sorted Array --> " + "{0}", string.Join(",", numbers));
Console.ReadLine();


bool IsArrayDone()
{           
    bool isArrayValid = true;
    for (int i = numbers.Length - 1; i >= 1; i--)
    {
        if (numbers[i] < numbers[i - 1])
            isArrayValid = false;
    }
    return isArrayValid;
}