public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int count = 0;
        while(true)
        {                        
            if(seoul[count] =="Kim" )
            {
                return answer = "김서방은"+" "+ count+"에 있다";
            }
             count++;                
        }
        
        return answer;
    }
}