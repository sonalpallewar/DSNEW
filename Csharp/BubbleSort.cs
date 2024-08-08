using System;

public class Program
{
    public static void Main()
    {
        int[] arrayInitial = { 100, 67, 95, 34, 1, 82, 23, 56, 74, 48, 99 };
        Console.WriteLine("Array initial: " + Extensions.ArrayIntToString(arrayInitial));

        var sorted = new PancakeSort().Execute(arrayInitial);
        Console.WriteLine("Array sorted by Pancake Sort: " + Extensions.ArrayIntToString(sorted));
    }
}

public class PancakeSort
{
    public int[] Execute(int[] array)
    {
        // Start from the full array and reduce it gradually
        int n = array.Length;
        for (int currSize = n; currSize > 1; --currSize)
        {
            // Find the index of the maximum element in the current array
            int maxIndex = FindMaxIndex(array, currSize);

            // Move the maximum element to the beginning of the array
            if (maxIndex != currSize - 1)
            {
                // Flip the array to move max element to the front
                Flip(array, maxIndex);
                // Flip the array to move max element to the correct position
                Flip(array, currSize - 1);
            }
        }
        return array;
    }

    private int FindMaxIndex(int[] arr, int n)
    {
        int maxIndex = 0;
        for (int i = 0; i < n; ++i)
        {
            if (arr[i] > arr[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    private void Flip(int[] arr, int end)
    {
        int start = 0;
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}
