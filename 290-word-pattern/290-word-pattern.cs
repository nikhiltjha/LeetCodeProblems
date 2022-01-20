public class Solution {
    public bool WordPattern(string pattern, string s) 
    {
        if(pattern.Length ==0 && s.Length ==0) return true;
        var tokens = s.Split(" ");
        if(pattern.Length != tokens.Length) return false;
        var dict = new Dictionary<char,string>();
        var reverseMap = new Dictionary<string,char>();
        for(int i=0;i<pattern.Length;i++)
        {
            if(dict.ContainsKey(pattern[i]))
            {
                if(dict[pattern[i]]!=tokens[i])
                    return false;
            }
            else
            {
                if(reverseMap.ContainsKey(tokens[i]))
                    return false;
                dict[pattern[i]] = tokens[i];
                reverseMap[tokens[i]] =pattern[i];
            }
                  
        }
        return true;
        
    }
}