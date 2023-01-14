
string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        Console.Write(text+result);
    }
    return result;
}

Method4(10, "8! ");