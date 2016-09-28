// http://blog.csdn.net/jiankunking/article/details/17992517
public class HeapSorter  
{  
    public static int[] Sort(int[] sortArray)  
    {  
        BuildMaxHeap(sortArray);  
        for (int i = (sortArray.Length - 1); i > 0; i--)  
        {  
            Swap(ref sortArray[0], ref sortArray[i]); // 将堆顶元素和无序区的最后一个元素交换  
            MaxHeapify(sortArray, 0, i); // 将新的无序区调整为堆，无序区在变小              
        }  
        return sortArray;  
    }  
    /// <summary>  
    /// 初始大根堆，自底向上地建堆  
    /// 完全二叉树的基本性质，最底层节点是 n/2，所以从 sortArray.Length / 2 开始  
    /// </summary>  
    private static void BuildMaxHeap(int[] sortArray)  
    {  
        for (int i = (sortArray.Length / 2) - 1; i >= 0; i--)  
        {  
            MaxHeapify(sortArray,i, sortArray.Length);  
        }  
    }  
    /// <summary>  
    /// 将指定的节点调整为堆  
    /// </summary>  
    /// <param name="i">需要调整的节点</param>  
    /// <param name="heapSize">堆的大小，也指数组中无序区的长度</param>  
    private static void MaxHeapify(int[] sortArray, int i, int heapSize)  
    {  
        int left = 2 * i + 1; // 左子节点  
        int right = 2 * i + 2; // 右子节点  
        int larger = i; // 临时变量，存放大的节点值  
        // 比较左子节点  
        if (left < heapSize && sortArray[left] > sortArray[larger])  
        {  
            larger = left;  
        }  
        // 比较右子节点  
        if (right < heapSize && sortArray[right] > sortArray[larger])  
        {  
            larger = right;  
        }  
        // 如有子节点大于自身就交换，使大的元素上移。  
        if (i != larger)  
        {  
            Swap(ref sortArray[i], ref sortArray[larger]);  
            MaxHeapify(sortArray, larger, heapSize);  
        }  
    }  
    
    private static void Swap(ref int a, ref int b)  
    {  
        int t;  
        t = a;  
        a = b;  
        b = t;  
    }  
}  