public class Solution {
    public int LongestPalindrome(string s) 
    {
        var dict = new Dictionary<char,int>();
        var odd = false;
        var len =0;
        foreach(char c in s)
        {
            if(dict.ContainsKey(c))
            {
                dict[c] = dict[c]+1;
            }
            else
            {
                dict[c] = 1;
            }
        }
        foreach(var (key,val) in dict)
        {
            if(val%2 ==0)
            {
                len =len + val;
            }
            else
            {
                len = len + val -1;
                odd = true;
            }
        }
        if(odd)
            return len+1;
        return len;
        
        
    }
}