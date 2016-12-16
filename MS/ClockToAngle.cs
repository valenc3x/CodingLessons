using System;

public int ClockToAngle(int h, int m){
    int ah = (int)(0.5 * (h * 60 + m));
    int am = 6 * m;
    return Math.Abs(am - ah);
}

Console.WriteLine(ClockToAngle(3, 0));
Console.WriteLine(ClockToAngle(11, 45));
Console.WriteLine(ClockToAngle(9, 30));
