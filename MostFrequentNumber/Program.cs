
namespace MostFrequentNumber
{
    internal class Program
    {
        private static int _mostFrequentNumber;
        static void Main(string[] args)
        {
            // Main array of number.
            int[] intArray = new int[] { 9, 9, 9, 9, 8, 8, 8, 8, 8, 5, 8, 5, 8, 6, 95, 78, 4, 4, 64, 1, 96785, 4674, 96, 49, 67, 0, 9, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18 };

            // List of int for controlling whether number is found inside the array before or not.
            List<int> listOfInts = new List<int>();

            // Index array of indexes for tracking repeating number inside of our 'intArray'.
            int[] indexes = new int[intArray.Length];

            for (int i = 0; i < intArray.Length; i++)
            {
                int currentNumber = intArray[i];
                listOfInts.Add(currentNumber);

                // If the number found before, it finds the index of number found inside the indexes array and increase it 1.
                if (listOfInts.Contains(currentNumber))
                    indexes[listOfInts.FindIndex(x => x == currentNumber)]++;
            }

            _mostFrequentNumber = intArray[Array.FindIndex(indexes, x => x == indexes.Max())];

            Console.WriteLine($"{_mostFrequentNumber} is the most frequent number in the array");
            Console.ReadLine();

        }


    }
}