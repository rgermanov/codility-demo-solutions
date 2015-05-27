using System;

// https://codility.com/demo/results/demoDCYG82-26A/#task-0

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);        
        for (int i = 0; i<A.Length; i++)
        {
            if (A[i] != i + 1)
            {
                return i + 1;
                break;
            }
        }
        return A.Length + 1;
    }
}
