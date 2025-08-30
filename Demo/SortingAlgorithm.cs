using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    static class SortingAlgorithm<T>
    
    {
        public static void BubbleSort(T[] arr, CustomFunc<T,T,bool> comparer)
        {
            if (arr?.Length > 0 && comparer is not null)
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (comparer.Invoke(arr[j], arr[j+1]))
                            swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

        }

        private static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
