/*
17. Letter Combinations of a Phone Number

Given a digit string, return all possible letter combinations that the number could represent.

A mapping of digit to letters (just like on the telephone buttons) is given below.



Input:Digit string "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
Note:
Although the above answer is in lexicographical order, your answer could be in any order you want.

*/
using System.Collections.Generic;

public class Solution017 {
    Dictionary<char, List<char>> keyboard = new Dictionary<char, List<char>>
        {
            { '2', new List<char>{ 'a','b','c'} },
            { '3', new List<char>{ 'd','e','f'} },
            { '4', new List<char>{ 'g','h','i'} },
            { '5', new List<char>{ 'j','k','l'} },
            { '6', new List<char>{ 'm','n','o'} },
            { '7', new List<char>{ 'p','q','r','s'} },
            { '8', new List<char>{ 't','u','v'} },
            { '9', new List<char>{ 'w','x','y','z'} }
        };

    public IList<string> LetterCombinations(string digits) {
        IList<string> ansList = new List<string>();
        if (digits == "") 
            return ansList;

        string ans = "";
        calc(digits, 0, digits.Length, ans, ansList);
        return ansList;
    }

    private void calc(string digit, int pos, int length, string ans, IList<string> ansList) 
    {
        if (pos == length)
        {
            ansList.Add(ans);
            return;
        }
        foreach (char c in this.keyboard[digit[pos]])
        {
            calc(digit, pos + 1, length, ans + c, ansList);
        }
    }
}

