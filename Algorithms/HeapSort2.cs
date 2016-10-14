public static void HeapSort(this int[] arry, int top)
{
    List<int> topNode = new List<int>();

    for (int i = arry.Length / 2 - 1; i >= 0; i--)
    {
        HeapAdjust(arry, i, arry.Length);
    }

    for (int i = arry.Length - 1; i >= arry.Length - top; i--)
    {
        int temp = arry[0];
        arry[0] = arry[i];
        arry[i] = temp;
        HeapAdjust(arry, 0, i);
    }
}


/// <summary>
/// 构建堆
/// </summary>
/// <param name="arry"></param>
/// <param name="parent"></param>
/// <param name="length"></param>
private static void HeapAdjust(int[] arry, int parent, int length)
{
    int temp = arry[parent];

    int child = 2 * parent + 1;

    while (child < length)
    {
        if (child + 1 < length && arry[child] < arry[child + 1]) child++;

        if (temp >= arry[child])
            break;

        arry[parent] = arry[child];

        parent = child;

        child = 2 * parent + 1;
    }

    arry[parent] = temp;
}