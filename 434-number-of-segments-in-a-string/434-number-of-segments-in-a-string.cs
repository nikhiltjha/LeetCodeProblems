public class Solution {
    public int CountSegments(string s) 
    {
        return s.Split(" ").Where(x=>x!="").Count();
    }
}