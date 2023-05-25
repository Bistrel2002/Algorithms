namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
         
            for(var i = 0; i < array.Length; i++)
            {
                for(var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp= array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        public static void MergeSort(int[] array)
        {
            var i = 0;
            var j = array.Length - 1;
            while (array[i] < array[j]) 
            {
              var middle =  (array[i] +array[j]) / 2;
            }
        }

        public static void HeapSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BubbleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void ShuffleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void IntroSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void CocktailSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void QuickSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BlockSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BogoSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }
    }
}
