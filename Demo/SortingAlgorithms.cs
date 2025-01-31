using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool SortingFuncDelegate(int A, int B);

    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] Arr, SortingFuncDelegate reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }

        //public static void BubbleSortAescending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingConditions.CompareGtr(Arr[j],Arr[j + 1])) 
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSortDescending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingConditions.CompareLess(Arr[j], Arr[j + 1]))
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}



        //public static void BubbleSortAescending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i -1; j++) 
        //            {
        //                if (Arr[j] > Arr[j + 1]) // SWAP
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }                    
        //        }
        //    }
        //}

        //public static void BubbleSortDescending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] < Arr[j + 1]) // SWAP
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        private static void SWAP(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
    }
}
