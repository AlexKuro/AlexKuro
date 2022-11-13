int Max(int a, int b, int c)
{
    int max = a; 
    if (b > max) max = b; 
    if (c > max) max = c;
    return max;
}

int a1 = 5, 
    a2 = 6, 
    a3 = 8,
    b1 = 23, 
    b2 = 9,
    b3 = 10,
    c1 = 22,
    c2 = 18,
    c3 = 20;

//int max = a1;

/*if (a2 > max) max = a2; 
if (a3 > max) max = a3; 

if (b1 > max) max = b1; 
if (b2 > max) max = b2; 
if (b3 > max) max = b3; 

if (c1 > max) max = c1; 
if (c2 > max) max = c2; 
if (c3 > max) max = c3; */ 

/*
int max_1, max_2, max_3;
max_1 = Max(a1, a2, a3);
max_2 = Max(b1, b2, b3);
max_3 = Max(c1, c2, c3);
int result = Max(max_1, max_2, max_3);
*/

int result = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));
Console.WriteLine(result);

