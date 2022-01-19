public class Solution {
    public char FindTheDifference(string s, string t) 
    {   /*
       //using dictionary
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
        */
        //using exor property
        var len1 = s.Length;
        if(len1==0) return t[0];
        int c = (int)s[0] ^ (int)t[0];
        for(int i=1;i<len1;i++)
        {
            c = c ^ (int)s[i] ^ (int)t[i];
        }
        return (char)(c ^ (int)t[len1]);


        
        
        
    }
}