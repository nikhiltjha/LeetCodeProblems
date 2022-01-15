public class Solution {
    public bool IsValid(string s) 
    {
        if(s==null || s.Length==0)
            return false;
        var bracketReverseMapperDict = new Dictionary<char,char>(){{')','('},{'}','{'},{']','['}};
        var bracketMapperDict = new Dictionary<char,char>(){{'(',')'},{'{','}'},{'[',']'}};
        var stack = new Stack<char>();
        foreach(char c in s)
        {
            if(bracketMapperDict.ContainsKey(c))
               stack.Push(c);
            if(bracketReverseMapperDict.ContainsKey(c))
               {
                   if(stack.Count !=0 && stack.Pop() == bracketReverseMapperDict[c])
                       continue;
                    return false;
                       
               }
            
        }
        return stack.Count ==0; 
    }
}