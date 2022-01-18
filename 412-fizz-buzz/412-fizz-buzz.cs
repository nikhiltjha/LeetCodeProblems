public class Solution {
    public IList<string> FizzBuzz(int n) {
        var resultStringList = new List<string>();
        var fizzBuzzDict = new Dictionary<int,string>(){{3,"Fizz"},{5,"Buzz"}};
        for(int num = 1; num <=n; num++)
        {
            var sb = new StringBuilder();
            foreach(var (key,val) in fizzBuzzDict)
            {
                if(num%key ==0)
                    sb.Append(val);
            }
            if(sb.Length>0)
                resultStringList.Add(sb.ToString());
            else
                resultStringList.Add(num.ToString());
        }
        return resultStringList;
        
    }
}