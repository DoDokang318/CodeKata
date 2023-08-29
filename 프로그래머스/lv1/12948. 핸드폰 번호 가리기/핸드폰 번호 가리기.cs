public class Solution {
    public string solution(string phone_number) {
        string answer = "";       
        char[] Charnum = phone_number.ToCharArray();
        
        for(int i = 0 ; i <=Charnum.Length;i++ )
        {
            if(i>4)
            {
            Charnum[Charnum.Length-i] = '*';
            }
           
                
        }
       return new string(Charnum);
    }
}