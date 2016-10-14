/*
     Bucket Sort (O(M+N)) 
     Bubble Sort（o(n2)
     Select Sort（o(n2)），
     Insert Sort（o(n2)），
     Heap Sort（o(nlogn)），
     Merge排序（o(nlogn)），
     Quick排序（o(nlogn)）
*/

public class Sorting{

    // O(M+N)，M为桶的个数，N为待排序的个数
    public static void BucketSort(IList arrayToSort)
    {
        if (arrayToSort == null || arrayToSort.Count == 0) return arrayToSort;

        object max = arrayToSort[0];
        object min = arrayToSort[0];


        for (int i = 0; i < arrayToSort.Count; i++)
        {

            if (((IComparable)arrayToSort[i]).CompareTo(max) > 0)
            {
                max = arrayToSort[i];
            }

            if (((IComparable)arrayToSort[i]).CompareTo(min) < 0)
            {
                min = arrayToSort[i];
            }
        }
        ArrayList[] holder = new ArrayList[(int)max - (int)min + 1];

        for (int i = 0; i < holder.Length; i++)
        {
            holder[i] = new ArrayList();
        }

        for (int i = 0; i < arrayToSort.Count; i++)
        {
            holder[(int)arrayToSort[i] - (int)min].Add(arrayToSort[i]);
        }

        int k = 0;

        for (int i = 0; i < holder.Length; i++)
        {
            if (holder[i].Count > 0)
            {
                for (int j = 0; j < holder[i].Count; j++)
                {
                    arrayToSort[k] = holder[i][j];
                    RedrawItem(k);
                    pnlSamples.Refresh();
                    if (chkCreateAnimation.Checked)
                        SavePicture();
                    k++;
                }
            }
        }

        return arrayToSort;

    }
    //o(n2)
    public static void BubbleSort(IList<int> data)
    {
        for (int i = data.Count - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (data[j] > data[j + 1])
                    Swap(data, j, j + 1);
            }
        }
    }

    // 找出参与排序的数组最大值，放到末尾（或找到最小值放到开头）o(n2)
    public static void SelectSort(IList<int> data)
    {
        for (int i = 0; i < data.Count - 1; i++)
        {
            int minIndex = i;
            int minVal = data[i];
            for (int j = i + 1; j < data.Count; j++)
            {
                if (data[j] < temp)
                {
                    minIndex = j;
                    minValue = data[j];
                }
            }
            if (minIndex != i)
                Swap(data, minIndex, i);
        }
    }

    // 通过构建有序数列，将未排序的数从后向前比较，找到合适位置并插入。o(n2)
    public static void InsertSort(IList<int> data)
    {
        int temp;
        for (int i = 1; i < data.Count; i++)
        {
            temp = data[i];
            for (int j = i - 1; j >= 0; j--)
            {
                if (data[j] > temp)
                {
                    data[j + 1] = data[j];
                    if (j == 0)
                    {
                        data[0] = temp;
                        break;
                    }
                }
                else
                {
                    data[j + 1] = temp;
                    break;
                }
            }
        }
    }

    // 从数列中挑选一个数作为“哨兵”，使比它小的放在它的左侧，比它大的放在它的右侧。
    public static void QuickSortStrict(IList<int> data)
    {
        QuickSortStrict(data, 0, data.Count - 1);
    }

    public static void QuickSortStrict(IList<int> data, int low, int high)
    {
        if (low >= high) return;
        int temp = data[low];
        int i = low + 1, j = high;
        while (true)
        {
            while (data[j] > temp) j--;
            while (data[i] < temp && i < j) i++;
            if (i >= j) break;
            Swap(data, i, j);
            i++; j--;
        }
        if (j != low)
            Swap(data, low, j);
        QuickSortStrict(data, j + 1, high);
        QuickSortStrict(data, low, j - 1);
    }


    public static IList<int> MergeSort(IList<int> data)
    {
        data = MergeSort(data, 0, data.Count - 1);
        return data;
    }

    public static IList<int> MergeSort(IList<int> data, int low, int high)
    {
        int length = high - low + 1;
        IList<int> mergeData = NewInstance(data, length);
        if (low == high)
        {
            mergeData[0] = data[low];
            return mergeData;
        }
        int mid = (low + high) / 2;
        IList<int> leftData = MergeSort(data, low, mid);
        IList<int> rightData = MergeSort(data, mid + 1, high);
        int i = 0, j = 0;
        while (true)
        {
            if (leftData[i] < rightData[j])
            {
                mergeData[i + j] = leftData[i++]; 
                if (i == leftData.Count)
                {
                    int rightLeft = rightData.Count - j;  // how many data left in right part
                    for (int m = 0; m < rightLeft; m++)
                    {
                        mergeData[i + j] = rightData[j++];
                    }
                    break;
                }
            }
            else
            {
                mergeData[i + j] = rightData[j++];
                if (j == rightData.Count)
                {
                    int leftleft = leftData.Count - i;   // how many data left in left part
                    for (int n = 0; n < leftleft; n++)
                    {
                        mergeData[i + j] = leftData[i++];
                    }
                    break;
                }
            }
        }
        return mergeData;

    }


    public static void HeapSort(IList<int> data)
    {
        BuildMaxHeapify(data);
        int j = data.Count;
        for (int i = 0; i < j; )
        {
            Swap(data, i, --j);
            if (j - 2 < 0)  //只剩下1个数 j代表余下要排列的数的个数
                break;
            int k = 0;
            while (true)
            {
                if (k > (j - 2) / 2) break;  //即：k > ((j-1)-1)/2 超出最后一个父节点的位置  
                else
                {
                    int temp = k;
                    k = ReSortMaxBranch(data, k, 2 * k + 1, 2 * k + 2, j - 1);
                    if (temp == k) break;
                }
            }
        }
    }

    public static void BuildMaxHeapify(IList<int> data)
    {
        for (int i = data.Count / 2 - 1; i >= 0; i--)  //(data.Count-1)-1)/2为数列最大父节点索引
        {
            int temp = i;
            temp = ReSortMaxBranch(data, i, 2 * i + 1, 2 * i + 2, data.Count - 1);
            if (temp != i)
            {
                int k = i;
                while (k != temp && temp <= data.Count / 2 - 1)
                {
                    k = temp;
                    temp = ReSortMaxBranch(data, temp, 2 * temp + 1, 2 * temp + 2, data.Count - 1);
                }
            }
        }
    }

    public static int ReSortMaxBranch(IList<int> data, int maxIndex, int left, int right, int lastIndex)
    {
        int temp;
        if (right > lastIndex)  //父节点只有一个子节点
            temp = left;
        else
        {
            if (data[left] > data[right])
                temp = left;
            else temp = right;
        }

        if (data[maxIndex] < data[temp])
            Swap(data, maxIndex, temp);
        else temp = maxIndex;
        return temp;
    }
}