using System;

public class SpaceAge
{
    private int secs;
    private double earthyears;

    public SpaceAge(int seconds)
    {
        secs = seconds;
        earthyears = secs/31557600.0;
    }

    public double OnEarth()
    {
        return Math.Round(earthyears, 2);
    }

    public double OnMercury()
    {
        return Math.Round(earthyears/0.2408467, 2); 
    }

    public double OnVenus()
    {
        return Math.Round(earthyears/0.61519726, 2); 
    }

    public double OnMars()
    {
        return Math.Round(earthyears/1.8808158, 2); 
    }

    public double OnJupiter()
    {
        return Math.Round(earthyears/11.862615, 2); 
    }

    public double OnSaturn()
    {
        return Math.Round(earthyears/29.447498, 2); 
    }

    public double OnUranus()
    {
        return Math.Round(earthyears/84.016846, 2); 
    }

    public double OnNeptune()
    {
        return Math.Round(earthyears/164.79132, 2); 
    }
}