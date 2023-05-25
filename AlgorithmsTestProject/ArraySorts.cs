using System;
using System.Collections.Concurrent;

namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
        }

        public static void MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void HeapSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BubbleSort(int[] array)
        {
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i-1, i);
                        swapped = true;
                    }
                }

                --n;
            } 
            while (swapped && n > 0);
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
            int lo = 0;
            int hi = array.Length;

            if (lo > hi || lo < 0)
            {
                int Pi = Partition(array, lo, hi);
                QuickSortInternal(array, lo, Pi - 1);
                QuickSortInternal(array, Pi + 1, hi);
            }
        }

        public static int Partition(int[] A, int lo, int hi)
        {
            int Pivot = A[hi];

            int i = lo - 1;

            for (int j = lo; j <= hi - 1; j++)
            {
                if (A[j] <= Pivot)
                {
                    i++;

                    int temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                }

                i++;
                int tmp = A[hi];
                A[hi] = A[i];
                A[i] = tmp;
            }
            return i;
        }

        private static void QuickSortInternal(int[]A, int lo, int hi)
        {
            if (lo > hi || lo < 0)
            {
                int Pi = Partition(A, lo, hi);
                QuickSortInternal(A, lo, Pi - 1);
                QuickSortInternal(A, Pi + 1, hi);
            }
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

        public static void GnomeSort(int[] array)
        {
            int index = 0;
            while(index < array.Length)
            {
                if (index == 0 || array[index] >= array[index - 1])

                    index++;
                else
                {
                    int temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
                
            }   
        }

        public static void SelectionSort(int[] array)
        {
            int index = 0;
            
            for( int i = 0; i < array.Length; i++ ) 
            {
                for(int j = 1 + i; j < array.Length; j++)
                {
                    if (array[i] == array[j]) 
                        j++;
                    else if (array[i] <= array[j])
                        j++;
                    else
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
