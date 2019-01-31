using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool ret = false;
        if (year%4 == 0){
            if (year%100 == 0){
                if (year%400 == 0){
                    ret = true;
                }
            } else {
                ret = true;
            }
        }
        return ret;
    }
}