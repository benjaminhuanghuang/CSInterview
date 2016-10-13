/*
127. Word Ladder
Given two words (beginWord and endWord), and a dictionary's word list, find the length of shortest 
transformation sequence from beginWord to endWord, such that:

Only one letter can be changed at a time
Each intermediate word must exist in the word list
For example,

Given:
beginWord = "hit"
endWord = "cog"
wordList = ["hot","dot","dog","lot","log"]
As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
return its length 5.

Note:
Return 0 if there is no such transformation sequence.
All words have the same length.
All words contain only lowercase alphabetic characters.

*/
using System.Collections.Generic;

public class Solution127 {
    public int LadderLength(string beginWord, string endWord, ISet<string> wordList) 
    {
        HashSet<string> reached = new HashSet<string>();
        reached.Add(beginWord);
        wordList.Add(endWord);
        int distance = 1;
        while(!reached.Contains(endWord)) {
            HashSet<string> toAdd = new HashSet<string>();
            foreach(string each in reached) {
                for (int i = 0; i < each.Length; i++) {
                    char[] chars = each.ToCharArray();
                    for (char ch = 'a'; ch <= 'z'; ch++) {
                        chars[i] = ch;
                        string word = new string(chars);
                        if(wordList.Contains(word)) {
                            toAdd.Add(word);
                            wordList.Remove(word);
                        }
                    }
                }
            }
            distance ++;
            if(toAdd.Count == 0) 
                return 0;
            reached = toAdd;
        }
        return distance;
    }
}