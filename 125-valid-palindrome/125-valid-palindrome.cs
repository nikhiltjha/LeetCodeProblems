//using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) 
    {
       //var str =s.ToLower();
        //str = Regex.Replace(str,"[^a-z0-9]","");
        //without using regular expression and string methods
        var str = RemoveNonAlphaNumericCharacterAndConvertToLower(s);
        var len = str.Length;
        if(len ==0)
            return true;
        for(int i =0; i<=len/2;i++)
        {
            if(str[i]!=str[len-1-i])
                return false;
        }
    return true;    
    }
    
    private string RemoveNonAlphaNumericCharacterAndConvertToLower(string s)
    {
        var sb = new StringBuilder();
        foreach(char c in s)
        {
            if((c>='A' && c<='Z'))
            {
                sb.Append((char)((int)(c-'A'+'a')));
                
            }
            if((c>='a' && c<='z') ||(c>='0' && c<='9'))
            {
                sb.Append(c);
            }
                
        }
        return sb.ToString();
    } 
}