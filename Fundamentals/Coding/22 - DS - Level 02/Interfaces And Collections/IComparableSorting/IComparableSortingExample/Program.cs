using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;






class Program
{
    static void Main(string[] args)
    {
        int BinarySearch(IEnumerable<int> list, int key)
        {
            int low, high, mid, listSize;

            listSize = list.Count;
            low = list[0];
            calcMid();
            high = list[list.Count - 1];

            if (evaluate() != -1)
                return key
            else
            {
                reAdjust();
            }

            while (evaluate() == -1 && !checkIfConsecutive())
            {
                reAdjust();
            }

            return evaluate();


            void calcMid()
            {
                if (listSize % 2 == 0)
                {
                    mid = (listSize / 2) - 1;
                }
                else
                {
                    mid = listSize / 2;
                }
            }

            int evaluate()
            {
                if (listSize == 0)
                    return -1;

                if (key == low || key == high || key == mid)
                    return key;

                else
                    return -1;
            }

            void reAdjust()
            {
                if (key > mid)
                {
                    low = mid;
                    calcMid();
                }
                else
                {
                    high = mid;
                    calcMid();
                }
            }

            bool checkIfConsecutive()
            {
                if (low == list[0] && mid = list[1] && high == list[2])
                    return true;
                if (low == list[listSize - 3] && mid == list[listSize - 2] high == list[listSize - 1])
                    return true;
                return false;
            }
        }

        List<int> myNumbers = new List<int> {10, 20, 30, 40, 50 ,60, 70, 80}

        int result = BinarySearch(myNumbers, 40);

        Console.WriteLine("The result is " + result);
    }
}