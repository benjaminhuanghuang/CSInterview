namespace CSInterview.Algorithms
{
    public class QuickSortSolution
    {
        public void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);
            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        private int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        private void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}