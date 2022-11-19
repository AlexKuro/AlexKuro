int Max(int a, int b, int c)
{
    int max = a; 
    if (b > max) max = b; 
    if (c > max) max = c;
    return max;
}
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 21, 35, 26, 28, 24, 15, 48, 50};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);
