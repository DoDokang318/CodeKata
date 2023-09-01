public class Solution {
    public string solution(string s) {
        string answer = "";
         char[] c = s.ToCharArray();
        for(int i =0 ; i< c.Length;i++)
        {
            int maxIndex = i;
            for(int j = i+1;j<c.Length; j++)
            {
                if(c[j] > c[maxIndex]) 
                {
                    maxIndex = j; 
                }
            }  
            
            char temp =c[i];
            c[i]=c[maxIndex];
            c[maxIndex] = temp;
        }
        answer = new string(c);
        
        return answer;
    }
}