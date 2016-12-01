/*
给定一个char array， 这个array是一个句子，然后给定一个字母，把这个array里面带有这个字母开头的单次删掉，操作是要求in place
    如 “a big ball is running” 'b' -> "a is running"
*/
using System;
public class Solution_DeleteWord {
    public string DeleteWord(string input, char c)
    {
        char[] charArray = input.ToCharArray();
        int slow = 0, fast = 0;
        bool skip = false;
        while(fast < input.Length)
        {
            if (!skip && charArray[fast] == c)
                skip = true;
            while(skip && fast < input.Length)
            {
                fast ++;
                if (charArray[fast] == ' ' && charArray[fast+1] != c)
                {
                    skip = false;
                    fast ++;
                }
            }
            if (fast < input.Length)
                charArray[slow++] = charArray[fast++]; 
        }

        string result = new String(charArray);

        return result.Substring(0, slow);
    }
}


/*
var s = new Solution_DeleteWord();
var result = s.DeleteWord("a big ball is running", 'b');
Console.WriteLine(result);
*/