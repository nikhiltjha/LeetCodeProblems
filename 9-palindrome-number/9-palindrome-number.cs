public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
            return false;
        
        var xString = x.ToString();
        var len = xString.Length;
        if(len ==1)
            return true;
        for(int i=0; i<=len/2;i++)
        {
            if(xString[i] != xString[len-1-i])
                return false;
        }
        return true;
        
    }
}