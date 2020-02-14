//Author: Justin Davis
//Date: 2/14/2020
//Purpose: The purpose to complete leet code challenge
//Faster than 99.30% of other solutions
//Less memory used than 100% of other solutions 
public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        int temp;
        string temp2;
        int product = 1;
        int sum = 0;
        string nn = n.ToString();
        for (int i = 0; i < nn.Length; i++)
        {
            temp2 = (nn.Substring(i, 1));
            temp = int.Parse(temp2);
            product *= temp;
            sum += temp;
        }
        int result = product - sum;
        return result;
    }
}