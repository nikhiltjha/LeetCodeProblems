public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) 
    {
        int rowLen = image.Length;
        int colLen = image.Length;
        
        for(int i =0; i< rowLen;i++)
        {
            for(int j= 0; j< (colLen+1)/2;j++)
            {
                int temp = image[i][j]; 
                image[i][j] = image[i][colLen-1-j] ^1;
                image[i][colLen-1-j] = temp ^1;
                
            }
        }
        return image;
            
            
        
    }
}