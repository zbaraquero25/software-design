namespace Task5_2
{
    public class DescendingSorter
    {
        public static int[] Sort(int[] numbers)
        {
            int[] sortedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; ++i)
            {
                sortedNumbers[i] = numbers[i];
            }

            for (int i = 0; i < numbers.Length - 1; ++i)
            {
                for (int j = i + 1; j < numbers.Length; ++j)
                {
                    if (sortedNumbers[j] > sortedNumbers[i])
                    {
                        int temp = sortedNumbers[i];
                        sortedNumbers[i] = sortedNumbers[j];
                        sortedNumbers[j] = temp;
                    }
                }
            }
            return sortedNumbers;
        }
    }
}
