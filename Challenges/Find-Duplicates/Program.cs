using System;

public class Program
{
    public static int[] FindDuplicates(int[] array)
    {
        int[] duplicates = new int[array.Length];
        int[] counts = new int[array.Length];
        
        int duplicateCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    counts[i]++;
                }
            }
        }

        // Find duplicates
        for (int i = 0; i < array.Length; i++)
        {
            if (counts[i] > 1)
            {
                bool isAlreadyAdded = false;
                for (int k = 0; k < duplicateCount; k++)
                {
                    if (duplicates[k] == array[i])
                    {
                        isAlreadyAdded = true;
                        break;
                    }
                }

                if (!isAlreadyAdded)
                {
                    duplicates[duplicateCount] = array[i];
                    duplicateCount++;
                }
            }
        }

        // Create the result array with the exact length
        int[] result = new int[duplicateCount];
        for (int i = 0; i < duplicateCount; i++)
        {
            result[i] = duplicates[i];
        }

        return result;
    }

    public static void Main()
    {
        //To test
        int[] input1 = { 1, 2, 3, 1, 2, 3 };
        int[] input2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
        int[] input3 = { 5, 10, 16, 20, 10, 16 };

        Console.WriteLine("Output 1: " + string.Join(", ", FindDuplicates(input1))); // Output: 1, 2, 3
        Console.WriteLine("Output 2: " + string.Join(", ", FindDuplicates(input2))); // Output: 17, 8
        Console.WriteLine("Output 3: " + string.Join(", ", FindDuplicates(input3))); // Output: 10, 16
    }
}
