Console.Clear();

int xa = 31, ya = 1, 
    xb = 1, yb = 31, 
    xc = 61, yc = 31;

int x = xa, y = ya, count = 0;

while (count < 100000) {
    int what = new Random().Next(0,3);

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x,y);
    Console.Write("*");
    ++count;
}
Console.SetCursorPosition(1,29);