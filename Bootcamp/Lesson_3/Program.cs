namespace Lesson_3;
class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, n];

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i * j);
                Console.Write("\t");
            }
            Console.WriteLine();
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix[i, j] = i*j;
                matrix[j, i] = i*j;
            }
            Console.WriteLine();
        }

    }
}
