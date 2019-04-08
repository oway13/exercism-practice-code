using System;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private int mask;

    public Allergies(int mask)
    {
        this.mask = 255 & mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        int allergen_ind = (int)allergen;
        int allergen_val = (int)Math.Pow(2, allergen_ind);
        return (this.mask & allergen_val) > 0;
    }

    public Allergen[] List()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}