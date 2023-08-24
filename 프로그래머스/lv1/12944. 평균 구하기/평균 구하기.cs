public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        double num = 0 ;
        for(int i =0 ; i < arr.Length ; i++)
        {
            
           num+= arr[i];
        }
        answer = num/arr.Length;
        
        return answer;
    }
}