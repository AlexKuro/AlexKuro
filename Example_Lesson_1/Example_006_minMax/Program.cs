Console.Clear();
//Console.SetCursorPosition(1, 1);
//Console.WriteLine("+");

int a = new Random().Next(-60,60),
    b = new Random().Next(-60,60),
    c = new Random().Next(-60,60),
    d = new Random().Next(-60,60),
    max;

int x = 0;
int y = 1;

while (x<10)
{
        while (y<2)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(">");
            y++;
        }
    x++;
    y = 1;
}

max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.SetCursorPosition(12, 1);
Console.Write("max = ");
Console.WriteLine(max);

Console.SetCursorPosition(14, 2);
Console.Write("a = ");
Console.WriteLine(a);
Console.SetCursorPosition(14, 3);
Console.Write("b = ");
Console.WriteLine(b);
Console.SetCursorPosition(14, 4);
Console.Write("c = ");
Console.WriteLine(c);
Console.SetCursorPosition(14, 5);
Console.Write("d = ");
Console.WriteLine(d);