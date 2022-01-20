public class Solution {
    public bool CanWinNim(int n) {
        if(n<4) return true;
         return n%4 !=0;
        
    }
}