public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        /*int n = poinst.Count();
        List<>
        int[] distSquare = new int[n];
        for(int i=0;i<n;i++)
        {
            distSquare[i] = Math.Pow(points[i][0],2) + Math.Pow(points[i][1],2)
        }*/
        
        return points.OrderBy(x=>x[0]*x[0] + x[1]*x[1]).Take(k).ToArray();
            
        
    }
}