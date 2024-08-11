using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdV04
{
    public delegate TResult ConditionalDelgate<in T,out TResult >(T A, T B);
    public delegate bool ConditionalDelgateV02(string A, string B);
    internal class SortingAlgorithm
    {
        public static void BubbleSortAssending <T>(T[] arr , ConditionalDelgate<T,bool>refernce)
        {

            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (refernce.Invoke( arr[j] , arr[j + 1]))
                        {
                            //swap
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }

            }
        }
        private static void Swap<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        //public static void BubbleSortAssending(int[] arr)
        //{

        //    if (arr != null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for(int j = 0;j<arr.Length-i -1; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    //swap
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }

        //    }
        //}
        //public static void BubbleSortAssendingDecending(int[] arr)
        //{

        //    if (arr != null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (arr[j] < arr[j + 1])
        //                {
        //                    //swap
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }

        //    }
        //}

        //public static void BubbleSortAssending(string[] arr,ConditionalDelgateV02 refernce)
        //{

        //    if (arr != null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (refernce.Invoke( arr[j] , arr[j + 1]))
        //                {
        //                    //swap
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }

        //    }
        //}

        //private static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //private static void Swap(ref string X, ref string Y)
        //{
        //    string Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

    }
}
