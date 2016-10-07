/*
93. Restore IP Addresses

Given a string containing only digits, restore it by returning all possible valid IP 
address combinations.

For example:
Given "25525511135",

return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)


*/

using System.Collections.Generic;

public class Solution093 {
    private List<string> resstr = new List<string>(); 
    public IList<string> RestoreIpAddresses(string s)
    {
        RestoreIpAddressesHelper(s, 0, 0, new List<string>());
        return resstr;
    }
    private void RestoreIpAddressesHelper(string s, int i, int segcount, List<string> result)
    {
        if (i >= s.Length)
        {
            if (segcount == 4)
            {
                resstr.Add(string.Join(".", result));
            }

            return;
        }

        if (segcount > 4) return;

        for (int len = 1; len <= 3; len++)             
        {                 
            if (!IsValid(s, i, len)) 
                continue;                 
            result.Add(s.Substring(i, len));                 
            RestoreIpAddressesHelper(s, i + len, segcount + 1, result);                 
            result.RemoveAt(result.Count - 1);             
        }         
    }         

    private bool IsValid(string s, int i, int len)         
    {             
        if (i + len > s.Length) 
            return false;
        if (len == 3 && int.Parse(s.Substring(i, len)) > 255) 
            return false;
        if (len > 1 && s[i] == '0') 
            return false;

        return true;
    }

    public IList<string> RestoreIpAddresses2(string s)
    {
        var res = new List<string>();
        for (int i = 1; i <= 3 && i < s.Length - 1; i++)
        {
            for (int j = i + 1; j <= i + 3 && j < s.Length - 2; j++)
            {
                for (int k = j + 1; k <= j + 3 && k < s.Length; k++)
                {
                    if(k + 3 < s.Length) 
                        continue;                         
                    var first = int.Parse(s.Substring(0, i));                         
                    var second = int.Parse(s.Substring(i, j - i));                         
                    var third = int.Parse(s.Substring(j, k - j));                         
                    var fourth = int.Parse(s.Substring(k));                         
                    if (first > 255 || second > 255 || third > 255 || fourth > 255) 
                        continue;
                    var candidate = first + "." + second + "." + third + "." + fourth;
                    if (candidate.Length != s.Length + 3) 
                        continue;

                    res.Add(candidate);
                }
            }
        }

        return res;    
    }
}

