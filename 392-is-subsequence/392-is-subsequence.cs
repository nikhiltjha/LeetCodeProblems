public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        var subLen = s.Length;
        var mainLen = t.Length;
        
        if(subLen==0) return true;
        if(subLen>mainLen) return false;
        
        var i=0;
        var j=0;
        while(i<mainLen && j<subLen)
        {
            if(s[j]==t[i])
            {
                j++;
            }
            i++;
        }
         return j==subLen;
    }
}