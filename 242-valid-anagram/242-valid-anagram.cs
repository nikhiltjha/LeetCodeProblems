public class Solution {
    public bool IsAnagram(string s, string t) {
        var len1 = s.Length;
        var len2 = t.Length;
        if(len1!=len2) return false;
        var dict = new Dictionary<char,int>();
        
        foreach(char c in s)
        {
            if(dict.ContainsKey(c))
                dict[c] += 1;
            else
                dict[c] = 1;
        }
        foreach(char c in t)
        {
            if(dict.ContainsKey(c))
                dict[c] -= 1;
            else
                return false;
        }
        foreach(var (key,val) in dict)
        {
             if(val != 0)
                 return false;
        }
        return true;
        
        
    }
}