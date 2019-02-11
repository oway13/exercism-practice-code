using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>{
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        for (int i = 0; i < sequence.Length; i++){
            if (!counts.ContainsKey(sequence[i])){
                throw new ArgumentException("Sequence contains invalid nucleotide. Valid nucleotides are 'A', 'C', 'G', 'T'.");
            }
            counts[sequence[i]]++;
        }
        return counts;
    }
}