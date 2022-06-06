int a = 10;
int b = 13;
int c = 15;
int d = 5;
int f = 8;
int result = a;
int max = Math.Max(a,Math.Max(Math.Max(b,c),Math.Max(d,f)));

if (b > result) result = b;
if (c > result) result = c;
if (d > result) result = d;
if (f > result) result = f;

Console.WriteLine("max = " + result);
Console.WriteLine("maxF = " + max);