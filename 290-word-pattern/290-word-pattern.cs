public class Solution {
    
    public bool WordPattern(string pattern, string s) 
    {
        if(pattern.Length ==0 && s.Length ==0) return true;
        var tokens = s.Split(" ");
        if(pattern.Length != tokens.Length) return false;
        var dict = new Dictionary<char,int>();
        var reverseMap = new Dictionary<string,int>();
        for(int i=0;i<pattern.Length;i++)
        {
            int firstOccLetter = -1;
            int firstOccWord = -1;
            if(dict.ContainsKey(pattern[i]))
            {
                firstOccLetter = dict[pattern[i]];
            }
            if(reverseMap.ContainsKey(tokens[i]))
            {
                firstOccWord = reverseMap[tokens[i]];
            }
            
            if(firstOccLetter != firstOccWord) {
                return false;
            }
               
            if(firstOccLetter == -1) {
                dict[pattern[i]] = i;
                reverseMap[tokens[i]] = i;
            }
        }
        return true;
    }
}