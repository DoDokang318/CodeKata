using System;



public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        string strnum = n.ToString();
        char[] Charnum = strnum.ToCharArray();
        Array.Sort(Charnum);
        Array.Reverse(Charnum);
        
         string sortedStrnum = new string(Charnum);
         answer = long.Parse(sortedStrnum);
        return answer;
    }
}