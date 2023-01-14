using static Sorting;
using static Infrastructure;
using System.Diagnostics;

namespace Lesson_4;
class Program
{
  static void Main(string[] args)
  {

    /* 10.CreateArray()
    .Show(", ")
    .SortSelection()
    .Show(", ");
*/
    int size = 15;
    int[] array = new int[size];
    int[] sortArray_1 = new int[size];
    int[] sortArray_2 = new int[size];
    int[] sortArray_3 = new int[size];
    int[] sortArray_4 = new int[size];

    FillArray(array);
    CopyArray(array, sortArray_1);
    CopyArray(array, sortArray_2);
    CopyArray(array, sortArray_3);
    CopyArray(array, sortArray_4);

    Console.WriteLine();
    Console.WriteLine("Способ I ---- Сортировка методом выбора");
    Stopwatch sw1 = new();
    sw1.Start();
    Show(array, ", ");
    SortSelection(sortArray_1);
    Show(sortArray_1, ", ");
    sw1.Stop();
    Console.WriteLine($" time I ---- Сортировка методом выбора = {sw1.ElapsedMilliseconds} ms");

    Console.WriteLine();
    Console.WriteLine("Способ II --- Пузырьковая сортировка");
    Stopwatch sw2 = new();
    sw2.Start();
    Show(array, ", ");
    SortВubble(sortArray_2);
    Show(sortArray_2, ", ");
    sw2.Stop();
    Console.WriteLine($" time II --- Пузырьковая сортировка = {sw2.ElapsedMilliseconds} ms");

    Console.WriteLine();
    Console.WriteLine("Способ III -- Шейкерная сортировка");
    Stopwatch sw3 = new();
    sw3.Start();
    Show(array, ", ");
    SortShaker(sortArray_3);
    Show(sortArray_3, ", ");
    sw3.Stop();
    Console.WriteLine($" time III -- Шейкерная сортировка = {sw3.ElapsedMilliseconds} ms");

    Console.WriteLine();
    Console.WriteLine("Способ IV --- Быстрая сортировка");
    Stopwatch sw4 = new();
    sw4.Start();
    Show(array, ", ");
    SortQuick(sortArray_4, 0, size - 1);
    Show(sortArray_4, ", ");
    sw4.Stop();
    Console.WriteLine($" time IV --- Быстрая сортировка = {sw4.ElapsedMilliseconds} ms");
   
  }
}
