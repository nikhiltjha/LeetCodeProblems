public class Solution {
    public string AddBinary(string a, string b) 
    {
        var aLen =a.Length;
        var bLen = b.Length;
        if(aLen>bLen)
            b = new String('0',aLen-bLen) + b;
         if(aLen<bLen)
            a = new String('0',bLen-aLen) + a;
        char carry = '0';
        string res ="";
        for(int i=a.Length-1; i>=0;i--)
        {
            char sum = (char)((int)a[i] ^ (int)b[i] ^ (int)carry);
            carry = (char)(((int)a[i]&(int)b[i]) | ((int)b[i]&(int)carry) | ((int)carry & (int)a[i]));
            res = sum.ToString()+ res;
        }
        if(carry =='0')
            return res;
        return "1"+ res;
        
        
    }
}