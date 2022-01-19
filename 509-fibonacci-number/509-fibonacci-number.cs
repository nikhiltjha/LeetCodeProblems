public class Solution {
    public static Dictionary<int,int> memoryDict = new Dictionary<int,int>(){{0,0},{1,1}};
    public int Fib(int n) 
    {
        if(memoryDict.ContainsKey(n))
             return memoryDict[n];
        else
        {
            memoryDict[n]=Fib(n-1) +Fib(n-2);
        }
        return memoryDict[n];    
    }
}