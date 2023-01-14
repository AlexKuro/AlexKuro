public static class Sorting
{

  static void Swap(ref int leftValue, ref int rightValue)
  {
    int temp = leftValue;
    leftValue = rightValue;
    rightValue = temp;
  }

  ///
  /// <summary>
  /// Сортировка методом выбора
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив</returns>
  public static void SortSelection(int[] collection)
  {
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
      int pos = i;
      for (int j = i + 1; j < size; j++)
      {
        if (collection[j] < collection[pos]) pos = j;
      }
      Swap(ref collection[i], ref collection[pos]);
    }
  }

  ///
  /// <summary>
  /// Пузырьковая сортировка
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив</returns>
  public static void SortВubble(int[] collection)
  {
    int size = collection.Length;
    for (int i = 0; i < size; i++)
    {
      for (int j = 0; j < size - 1; j++)
      {
        if (collection[j] > collection[j + 1])
        {
          Swap(ref collection[j], ref collection[j + 1]);
        }
      }
    }
  }

  ///
  /// <summary>
  /// Шейкерная сортировка 
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив</returns>
  public static void SortShaker(int[] collection) // шейкерная сортировка 
  {
    int size = collection.Length;
    for (var i = 0; i < collection.Length / 2; i++)
    {
      var swapFlag = false;
      //проход слева направо
      for (var j = i; j < collection.Length - i - 1; j++)
      {
        if (collection[j] > collection[j + 1])
        {
          Swap(ref collection[j], ref collection[j + 1]);
          swapFlag = true;
        }
      }

      //проход справа налево
      for (var j = collection.Length - 2 - i; j > i; j--)
      {
        if (collection[j - 1] > collection[j])
        {
          Swap(ref collection[j - 1], ref collection[j]);
          swapFlag = true;
        }
      }

      //если обменов не было выходим
      if (!swapFlag)
      {
        break;
      }
    }
  }

  ///
  /// <summary>
  /// Быстрая сортировка 
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив</returns>
  public static void SortQuick(int[] collection, int left, int right)
  {
    //[2, 3, 4, 7, 3, 1, 4, 8, 7, 8, 7, 1, 8, 5, 5] left = 0; right = 15- 1 = 14

    int i = left; //0
    int j = right; //14

    int pivot = collection[Random.Shared.Next(left, right)];

    while (i <= j)
    {
      while (collection[i] < pivot) i++;
      while (collection[j] > pivot) j--;

      if (i <= j)
      {
        Swap(ref collection[i], ref collection[j]);
        i++;
        j--;
      }
    }
    if (i < right) SortQuick(collection, i, right);
    if (left < j) SortQuick(collection, left, j);
  }
}