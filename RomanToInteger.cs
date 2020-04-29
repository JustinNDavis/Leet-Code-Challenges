//Author: Justin Davis
//Date 4/29/20
//LeetCode Challenge Roman To Integer
//runtime: 80 ms, faster than 94.53% per leetcode

public class Solution {
    public int RomanToInt(string s) 
    {
        int c = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'M')
            {
                c += 1000;
            }
            else if(s[i] == 'D')
            {
                c += 500;
            }
            else if(s[i] == 'C')
            {
                if(i+1 < s.Length)
                {
                    if(s[i+1] == 'D')
                    {
                        c+=400;
                        i+=1;
                    }
                    else if(s[i+1] == 'M')
                    {
                        c+=900;
                        i+=1;
                    }
                    else
                    {
                        c+=100;
                    }
                }
                else
                {
                    c+=100;
                } 
            }
            else if(s[i] == 'L')
            {
                c += 50;
            }
            else if(s[i] == 'X')
            {
                if(i+1 < s.Length)
                {
                    if(s[i+1] == 'L')
                    {
                        c+=40;
                        i+=1;
                    }
                    else if(s[i+1] == 'C')
                    {
                        c+=90;
                        i+=1;
                    }
                    else
                    {
                        c+=10;
                    }
                }
                else
                {
                    c+=10;
                }
              
            }
            else if(s[i] == 'V')
            {
                c+=5;
            }
            else if(s[i] == 'I')
            {
               if(i+1 < s.Length)
               {
                    if(s[i+1] == 'V')
                    {
                        c+=4;
                        i+=1;
                    }
                    else if(s[i+1] == 'X')
                    {
                        c+=9;
                        i+=1;
                    }
                    else
                    {
                        c+=1;
                    }
               }
                else
                {
                    c+=1;
                }
            }
        }
        return c;
    }
}