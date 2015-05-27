using System;

//https://codility.com/demo/results/demo6UDCHC-5J4/#task-0
class Solution {
    public int solution(int X, int Y, int D) {        
                
        int steps = (Y - X) / D;
        int remainder = (Y - X) % D;
        
        if (remainder > 0)
        {
            steps += 1;
        }
        
        return steps;         
    }
}