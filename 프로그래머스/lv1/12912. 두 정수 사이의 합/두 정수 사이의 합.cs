public class Solution {
    public long solution(long a, int b) {
        long answer = 0;
         
        if(a>=b)
        {
          long[] NumArray = new long[a-b+1];
            
            
            for(int i = 0  ; i < NumArray.Length ; i++)
            {
                NumArray[i]+= b++;
                   answer+=NumArray[i];
            }
        }
        else
        {
            long[] NumArray = new long[b-a+1];
            
              for(int i = 0  ; i < NumArray.Length ; i++)
            {
                NumArray[i]+= a++;
                   answer+=NumArray[i];
            }
            
            
        }
        
        return answer;
    }
}