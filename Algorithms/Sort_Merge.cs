/*
    step1: MergeSort(array's left half)
    step2: MergeSort(array's right half)
    step3: Merge left & right half
    
 */

namespace CSInterview.Algorithms
{
    public class MergeSortSoltion
    {
        public void MergeSort(int[] array)
        {
            MergeSort(array, new int[array.Length], 0, array.Length - 1);
        }

        public void MergeSort(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }

            int middle = leftStart + (rightEnd - leftStart) / 2;
            MergeSort(array, temp, leftStart, middle);
            MergeSort(array, temp, middle + 1, rightEnd);
            MergeHalves(array, temp, leftStart, rightEnd);
        }

        public void MergeHalves(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (array[left] < array[right])
                {
                    temp[index] = array[left];
                    left++;
                }
                else
                {
                    temp[index] = array[right];
                    right++;
                }
                index++;
            }
            // Copy rest part of left half [left] to temp[index]
            Array.Copy(array, left, temp, index, leftEnd - left + 1);
            // Copy rest part of right half to temp
            Array.Copy(array, right, temp, index, rightEnd - right + 1);
            // Copy temp to array
            Array.Copy(temp, leftStart, array, leftStart, size);
        }
    }
}