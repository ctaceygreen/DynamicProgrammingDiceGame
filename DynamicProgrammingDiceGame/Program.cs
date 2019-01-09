using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] maxResults = new int[A.Length];
        maxResults[0] = A[0];
        for(int i = 1; i < A.Length; i++)
        {
            int valueOfCurrentSquare = A[i];
            int diceVal = 1;
            int maxCombinedResultAtThisSquare = int.MinValue;
            while(i - diceVal >= 0 && diceVal <=6)
            {
                maxCombinedResultAtThisSquare = Math.Max(maxCombinedResultAtThisSquare, valueOfCurrentSquare + maxResults[i - diceVal]);
                diceVal++;
            }
            maxResults[i] = maxCombinedResultAtThisSquare;
        }
        return maxResults[A.Length - 1];
    }
}