using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime birthDate)
    {
        const int Gs = 1000000000;
        return birthDate.AddSeconds(Gs);
    }
}