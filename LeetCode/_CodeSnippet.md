using System;
using System.Collections.Generic;
// Online coding: https://dotnetfiddle.net/


// --------------------------------------------------------------------
// Chart
// --------------------------------------------------------------------
board[row, col] = Convert.ToChar(mineCount);  //it is unicode
board[row, col] = (char)(mineCount + '0');
// --------------------------------------------------------------------
// String
// --------------------------------------------------------------------
string s = "0123456789";
string subStr = s.Substring(3, 2);   // "34" index , COUNT

char[] array = s.ToCharArray();     //Reverse string
Array.Reverse(array);
s = new String(array);

string right = new string(array, 3, s.Length - 3);  // "6543210"

if (s.StartsWith(right))
    Console.WriteLine(right);

StringBuilder sb = new StringBuilder();
sb.Insert(0, s[remainder]);     // Insert char into sb
sb.Remove(1, 2);
s = sb.ToString();

// --------------------------------------------------------------------
// Array and Matrix
// --------------------------------------------------------------------
// Single-dimensional array (numbers).
int[] n1 = new int[4] {2, 4, 6, 8};
int[] n2 = new int[] {2, 4, 6, 8};
int[] n3 = {2, 4, 6, 8};

// Single-dimensional array (strings).
string[] s1 = new string[3] {"John", "Paul", "Mary"};
string[] s2 = new string[] {"John", "Paul", "Mary"};
string[] s3 = {"John", "Paul", "Mary"};

// Multidimensional array.
int[,] n4 = new int[3, 2] { {1, 2}, {3, 4}, {5, 6} };
int[,] n5 = new int[,] { {1, 2}, {3, 4}, {5, 6} };
int[,] n6 = { {1, 2}, {3, 4}, {5, 6} };
int[,] dir = { {0,1}, {0,-1}, {1,0}, {-1,0}, {1,1}, {1,-1}, {-1,1}, {-1,-1}};

// Jagged array.
int[][] n7 = new int[2][] { new int[] {2,4,6}, new int[] {1,3,5,7,9} };
int[][] n8 = new int[][] { new int[] {2,4,6}, new int[] {1,3,5,7,9} };
int[][] n9 = { new int[] {2,4,6}, new int[] {1,3,5,7,9} };

// Get array dimensions
int len = arr.Length;
int rows = board.GetLength(0);
int cols = board.GetLength(1);

// Sort
Array.Sort(nums);
            
// --------------------------------------------------------------------        
// List 
// --------------------------------------------------------------------
var list= new List<int>{1};
list.Add(2);

int[] arr = list.ToArray();

using System.Linq;
intervals = intervals.OrderBy(x => x.start).ToList();

// --------------------------------------------------------------------
// Dictionary
// --------------------------------------------------------------------
Dictionary<char, char> dict = new Dictionary<char, char>();
if (!dict.ContainsKey(s[i]))
    dict.Add(s[i], t[i]);
else
    if (dict[s[i]] != t[i])

// --------------------------------------------------------------------
// HashSet
// --------------------------------------------------------------------
HashSet<int> numSet = new HashSet<int>();
if (!numSet.Contains(nums[i]))
    numSet.Add(nums[i]);    
