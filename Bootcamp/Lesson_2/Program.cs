

using System.Diagnostics;

namespace Lesson_2;
class Program
{
    static void Main(string[] args)
    {

        int size = 10;
        int m = 3;
        int max_1 = 0;
        int max_2 = 0;
        int[] array = new int[size];
        //                +  +  +  
        //                0  1  2  3  4  5  6  7  8  9

        //int[] array = { 1, 5, 4, 1, 3, 4, 7, 4, 1, 11 };

        FillArray(array);
        PrintArray(array);

        Console.WriteLine();
        Console.WriteLine("Способ I");
        Stopwatch sw1 = new();
        sw1.Start();
        for (int i = 0; i < array.Length - m; i++)
        {
            int sum1 = 0;
            for (int j = i; j < i + m; j++)
            {
                sum1 += array[j];
                if (sum1 > max_1) max_1 = sum1;
            }
            //Console.Write($"{sum} ");
        }
        sw1.Stop();
        Console.WriteLine();
        Console.WriteLine($" time I  = {sw1.ElapsedMilliseconds} ms");
        Console.WriteLine($" MAX, способа I  --> {max_1}");

        Console.WriteLine();
        Console.WriteLine("Способ II");
        Stopwatch sw2 = new();
        sw2.Start();
        for (int j = 0; j < m; j++) max_2 += array[j];
        int sum = max_2;
        for (int i = 1; i < array.Length - m; i++)
        {
            sum = sum - array[i - 1] + array[i + (m - 1)];
            if (sum > max_2) max_2 = sum;
        }
        sw2.Stop();
        Console.WriteLine();
        Console.WriteLine($" time II = {sw2.ElapsedMilliseconds} ms");
        Console.WriteLine($" MAX, способа II --> {max_2}");

        void FillArray(int[] array, int minValue = 0, int maxValue = 9)
        {
            minValue++;
            Random rand = new Random();
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }
        }

        void PrintArray(int[] array)
        {
           Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

    }
}
