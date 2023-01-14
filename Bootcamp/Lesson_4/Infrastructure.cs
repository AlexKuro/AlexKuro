using static System.Console;
using static System.String;

public static class Infrastructure
{
  /// <summary>
  /// Метод создания и заполнения массива
  /// </summary>
  /// <param name="size">Размер нового массива</param>
  /// <param name="min">Нижняя граница заполнения</param>
  /// <param name="max">Верхняя граница заполнения</param>
  /// <returns>Новый массив</returns>
  public static int[] CreateArray(this int size, int min = 0, int max = 30)
  {
    return Enumerable.Range(1, size)
                     .Select(item => Random.Shared.Next(min, max))
                     .ToArray();
  }

  /// <summary>
  /// Вывод массива в консоль
  /// </summary>
  /// <param name="array">Исходный массив</param>
  /// <param name="separator">Символ-разделитель элементов массива</param>
  /// <returns>Исходный массив</returns>
  public static int[] Show(int[] array, string separator = ",")
  {
    string output = Join(separator, array);
    WriteLine($"[{output}]");
    return array;
  }

  public static void FillArray(int[] array, int minValue = 0, int maxValue = 9)
  {
    minValue++;
    Random rand = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
      array[i] = rand.Next(minValue, maxValue);
    }
  }

  public static void CopyArray(int[] array, int[] collection)
  {
    for (int i = 0; i < array.Length; i++) collection[i] = array[i];
  }
}