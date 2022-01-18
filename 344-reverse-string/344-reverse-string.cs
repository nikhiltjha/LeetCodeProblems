public class Solution {
    public void ReverseString(char[] s) {
        var len = s.Length;
        for(int i=0;i<len/2;i++)
        {
           var temp = s[i];
           s[i] = s[len-1-i];
           s[len-1-i] =temp;  
        }  
    }
}