/*
126. Word Ladder II

Given two words (beginWord and endWord), and a dictionary's word list, find all shortest 
transformation sequence(s) from beginWord to endWord, such that:

Only one letter can be changed at a time
Each intermediate word must exist in the word list
For example,

Given:
beginWord = "hit"
endWord = "cog"
wordList = ["hot","dot","dog","lot","log"]
Return
  [
    ["hit","hot","dot","dog","cog"],
    ["hit","hot","lot","log","cog"]
  ]
Note:
Return an empty list if there is no such transformation sequence.
All words have the same length.
All words contain only lowercase alphabetic characters.
You may assume no duplicates in the word list.
You may assume beginWord and endWord are non-empty and are not the same.

*/
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution126
{
    IList<IList<string>> res = new List<IList<string>>();

    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        if (!wordList.Contains(endWord))
            wordList.Add(endWord);
        BFS(beginWord, endWord, new List<string> { beginWord }, wordList);
        res = res.OrderBy(s=>s.Count).ToList();
        res = res.Where(s=>s.Count== res[0].Count).ToList();
        return res;
    }

    private void BFS(string currWord, string endWord, IList<string> ladder, IList<string> wordList)
    {
        Dictionary<string, List<string>> nextWords = GetNextWords(currWord, wordList);
        // Console.WriteLine("Ladder: "+ String.Join(" ", ladder));
        // Console.WriteLine("NextWords: "+ String.Join(" ", nextWords));
        if (nextWords.Count == 0)
        {
            return;
        }
        
        foreach (var nextWord in nextWords.Keys)
        {
            var newladder = new List<string>(ladder);
            newladder.Add(nextWord);
            if (nextWord == endWord)
            {
                res.Add(newladder);
            }
            else
            {
                BFS(nextWord, endWord, newladder, nextWords[nextWord]);
            }
        }
    }
    private Dictionary<string, List<string>> GetNextWords(string word, IList<string> dict)
    {
        var nextWords = new Dictionary<string, List<string>>();
        
        for (int i = 0; i < word.Length; i++)
        {
            var charArr = word.ToCharArray();
            for (char c = 'a'; c <= 'z'; c++)
            {
                charArr[i] = c;
                string newWord = new string(charArr);
                if (dict.Contains(newWord))
                {
                    if (!nextWords.ContainsKey(newWord))
                        nextWords.Add(newWord, dict.Where(w => w != newWord).ToList());
                }
            }
        }
        return nextWords;
    }
}

