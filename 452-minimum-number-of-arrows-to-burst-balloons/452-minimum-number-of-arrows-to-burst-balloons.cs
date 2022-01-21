public class Solution {
    public int FindMinArrowShots(int[][] points) 
    {
        if (points.Length ==0) return 0;
        var sortedPoints = points.OrderBy(x=>x[1]).ToArray();
        int count = 1;
        int currHead = sortedPoints[0][1];
        //Console.WriteLine($"count :{count} currHead: {currHead}");
        for(int i=1;i<sortedPoints.Length;i++)
        {
            //Console.WriteLine($"{sortedPoints[i][0]} {sortedPoints[i][1]}");
            if(currHead >=sortedPoints[i][0])
                continue;
            else
            {
                count++;
                currHead =sortedPoints[i][1];
            }
            //Console.WriteLine($"count :{count} currHead: {currHead}");
        }
        return count;
        
        
        
    }
}