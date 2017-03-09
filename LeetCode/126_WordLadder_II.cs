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
All words have the same length.
All words contain only lowercase alphabetic characters.
*/
using System;
using System.Collections.Generic;

public class Solution126
{
    IList<IList<string>> res = new List<IList<string>>();

    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        DFS(beginWord, endWord, new List<string>{beginWord}, wordList);
        return res;
    }

    private void DFS(string currWord, string endWord, IList<string> ladder, IList<string> wordList)
    {
        if (wordList.Count == 0)
        {
            return;
        }
        Console.WriteLine("Current Word: {0}", currWord);
        foreach(var w in wordList)
            Console.WriteLine("   Word in dic: {0}", w);
        
                
        char[] arr = currWord.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                char temp = arr[i];
                if (arr[i] != c)
                {
                    arr[i] = c;
                }

                String newWord = new String(arr);
                if (wordList.Contains(newWord))
                {
                    ladder.Add(newWord);
                    if (newWord == endWord)
                    {
                        res.Add(ladder);
                        return;
                    }
                    wordList.Remove(newWord);
                    
                    DFS(newWord, endWord, ladder, wordList);
                }

                arr[i] = temp;
            }
        }

    }
}

