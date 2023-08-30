public class Solution {
    public string solution(string s) {
        string answer = "";      
        char[] c = s.ToCharArray();
       char[] a = new char[c.Length % 2 == 0 ? 2 : 1];
        if(c.Length%2==0)
        {
            a[0]=c[c.Length/2-1];
            a[1]=c[c.Length/2];
            
        }
        else
        {
             a[0] = c[c.Length / 2];
        }
        answer = new string(a); 
        return answer;
    }
}