public class Solution {
    public char FindTheDifference(string s, string t) 
    {
        var dict = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(dict.ContainsKey(c))
                dict[c]= dict[c]+1;
            else
                dict[c] = 1;
        }
        foreach(char c in t)
        {
            if(!dict.ContainsKey(c) || dict[c]==0)
                return c;
            else
                dict[c] = dict[c]-1;
        }
        return ' ';
        
    }
}