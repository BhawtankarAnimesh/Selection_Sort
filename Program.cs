/*
 Author - Animesh Anup Bhawtankar
 Date - 02/28/2024
 Comments - This is a practice code for selection sort.
 */

namespace ConsoleApp2
{
    internal class Program
    {
        //Main function
        static void Main(string[] args)
        {
            int[] arr = { 5, 72, 3, 14, 7, 1 };
            int n = arr.Length;


            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }

            //Print the sorted array
            Console.WriteLine("Sorted array is:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}

