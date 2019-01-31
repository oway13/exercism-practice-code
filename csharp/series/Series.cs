using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length) {
            throw new ArgumentException("Slice Length must not be larger than Number Length.");
        }
        if (sliceLength < 1){
            throw new ArgumentException("Slice Length must be a positive integer");
        }
        if (numbers.Length < 1){
            throw new ArgumentException("Number  Length must be a positive integer");
        }

        int iters = numbers.Length - sliceLength + 1;
        string[] slices = new string[iters];
        for (int i = 0; i < iters; i++){
            slices[i] = numbers.Substring(i, sliceLength);
        }
        return slices;
    }
        
}