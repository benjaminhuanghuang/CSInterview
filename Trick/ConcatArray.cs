// Method 1 Convert array to List
var array = new string[] { "test" }.ToList();
var array1 = new string[] { "test" }.ToList();
array.AddRange(array1);
var result = array.ToArray();


// Method 2
var arr1 = new[] { 1, 2, 3, 4, 5 };
var arr2 = new[] { 6, 7, 8, 9, 0 };
var arr = arr1.Union(arr2).ToArray();

// Method 3 C# 3.0 Linq Concat
int[] front = { 1, 2, 3, 4 };
int[] back = { 5, 6, 7, 8 };
int[] combined = front.Concat(back).ToArray();

// Method 2  Array.Copy
int[] front = { 1, 2, 3, 4 };
int[] back = { 5, 6, 7, 8 };

int[] combined = new int[front.Length + back.Length];
Array.Copy(front, combined, front.Length);
Array.Copy(back, 0, combined, front.Length, back.Length);




