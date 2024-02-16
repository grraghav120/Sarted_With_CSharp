using System;

namespace ConsoleApp1.ArrayExercise
{
    internal class Search
    {
        public bool LinearSearch(List<int> arr,int key)
        {
            int n=arr.Count;
            bool foundElement = false;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == key)
                {
                    foundElement = true;
                    break;
                }
            }
            if(foundElement ) { return true; }
            return false;
        }
        public int BinarySearch(List<int> arr,int key)
        {
            int n= arr.Count;
            int start = 0, end = n - 1;
            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    start= mid + 1;
                }
                else
                {
                    end=mid-1;
                }
            }
            return -1;

        }
    }
}
