public class Solution {
    public string ConvertToTitle(int columnNumber) 
    {
        string sb = "";
        while(columnNumber > 0)
        {
            var rem = (columnNumber-1) % 26; 
            sb =(char)(rem +(int)'A') +sb;
            columnNumber =((columnNumber-1)/26);
        }
        return sb;
    
    }
}