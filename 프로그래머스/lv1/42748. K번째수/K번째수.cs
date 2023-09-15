using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
     int[] answer = new int[commands.GetLongLength(0)] ;
      
        for(int i = 0 ; i<commands.GetLength(0);i++)
        {
            int[] num = new int[commands[i,1]-commands[i,0]+1];
            int a = 0;
            // i,0에서부터
            //i,1만큼자르고 
            //정렬
            //i,2위치에있는 요소를
            //answer에넣기 
            for(int j =0 ; j<commands[i,1]-commands[i,0]+1;j++)
            {
                
                 num[a] = array[j+commands[i,0]-1];
                 a++;
            }
         Array.Sort(num);     
        answer[i] = num[commands[i, 2] - 1];
        }
        return answer;
    }
}