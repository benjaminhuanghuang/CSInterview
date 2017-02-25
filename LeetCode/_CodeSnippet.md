using System;
using System.Collections.Generic;

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

// Jagged array.
int[][] n7 = new int[2][] { new int[] {2,4,6}, new int[] {1,3,5,7,9} };
int[][] n8 = new int[][] { new int[] {2,4,6}, new int[] {1,3,5,7,9} };
int[][] n9 = { new int[] {2,4,6}, new int[] {1,3,5,7,9} };

// Get array dimensions
int len = arr.Length();
int rows = board.GetLength(0);
int cols = board.GetLength(1);

// List 
var list= new List<int>{1};
list.Add(2);

int[] arr = list.ToArray();
