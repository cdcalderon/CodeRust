using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRust
{
    public class ArraysDojo
    {
        public int BinarySearch(int[] a, int number)
        {
            var low = 0;
            var high = a.Length - 1;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (a[mid] == number)
                {
                    return a[mid];
                }

                if (number > a[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        public bool SumOfTwoValues(int[] a, int number)
        {
            var set = new HashSet<int>();
            foreach (var n in a)
            {
                var n2 = number - n;
                if (set.Contains(n2))
                {
                    return true;
                }
                set.Add(n);
            }

            return false;
        }

        public IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        public void permute(char[] arry, int i, int n)
        {
            int j;
            for (j = i; j <= n; j++)
            {
                swap(ref arry[i], ref arry[j]);
                permute(arry, i + 1, n);
                swap(ref arry[i], ref arry[j]); //backtrack
            }
        }



        public string FindMaxSlidingWindow(int[] array, int windowSize)
        {
            var s = "";
            if(array.Length < windowSize) return "";

            LinkedList<int> window = new LinkedList<int>();

            for (int i = 0; i < windowSize; i++)
            {
                while (window.Any() && array[i] >= array[window.Last()])
                {
                    window.RemoveLast();
                }
                window.AddLast(i);
            }

            s += array[window.Last()] + ",";

            for (int i = windowSize; i < array.Length; i++)
            {
                    while(window.Any() && 
                    array[i] >= array[window.Last()])
                {
                    window.RemoveLast();
                }

                if (window.Any() &&
                    window.Last() <= i - windowSize)
                {
                    window.RemoveFirst();
                }

                window.AddLast(i);

                s += array[window.First()] + ", ";
            }
            return s;
        }

        public int FindSmallestCommonNumberInArrays(int[] arr1, int[] arr2, int[] arr3)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < arr1.Length &&
                   j < arr2.Length &&
                   k < arr3.Length)
            {

                if (arr1[i] == arr2[j] &&
                    arr2[j] == arr3[k])
                {
                    return arr1[i];
                }


                if (arr1[i] <= arr2[j] &&
                    arr1[i] <= arr3[k])
                {
                    i++;
                } else if (arr2[j] <= arr1[i] &&
                           arr2[j] <= arr3[k])
                {
                    j++;
                }
                else if(arr3[k] <= arr1[i] &&
                    arr3[k] <= arr2[j])
                {
                    k++;
                }
            }
            return -1;
        }

        

        private void swap(ref char n1, ref char n2)
        {
            char temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
