public class Solution {
    public string AddStrings(string num1, string num2) 
    {
        int carry = 0;
        var len1 = num1.Length;
        var len2 = num2.Length;
        if(len1> len2)
            num2 = new String('0',len1-len2) + num2;
        if(len2> len1)
            num1 = new String('0', len2-len1) + num1;
        var sb = new StringBuilder();
        var len = num1.Length;
        for(int i= len-1;i>=0;i--)
        {
            int sum = (int)Char.GetNumericValue(num1[i]) + (int)Char.GetNumericValue(num2[i])+ carry;
            var digitChar = (sum%10).ToString();
            carry = sum/10;
            sb.Insert(0,digitChar);
        }
        if(carry>0)
            return carry.ToString() + sb.ToString();
        return sb.ToString();
        
    }
}