public class Solution {
    public int[] solution(long n) {
       
        
        string strnum = n.ToString();
        char[] Charnum = strnum.ToCharArray();
        
         int[] answer = new int[Charnum.Length] ;
        
        for(int i = 0 ; i < Charnum.Length ; i++)
        {
           answer[i] = int.Parse(Charnum[Charnum.Length - 1 - i].ToString());
        }
    
        return  answer;
    }
}