using System;

namespace Missing_Element_in_a_Sorted_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();
      int[] arr = new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
      // { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 19 }
      Console.WriteLine(p.SearchMissingElement(arr));
    }

    int SearchMissingElement(int[] arr)
    {
      int l = 0, r = arr.Length - 1;
      while (l <= r)
      {
        int mid = (r + l) / 2;
        // as the array is sorted and started from 1
        // if mid does not have mid + 1 element but the before mid position having correct element
        // (i.e. 1,2,4,5 = so mid id 2 and in 2nd index we have 4 and before 2nd index we have correct value 1,
        // so we have foound the correct position where the element is missing)
        if (arr[mid] != mid + 1 && arr[mid - 1] == mid)
        {
          return mid + 1;
        }

        // when mid position having correct element i.e no issues on the left half, have to perform BS in right half of mid, update your left position after mid.
        if (arr[mid] == mid + 1)
        {
          l = mid + 1;
        }
        else
        {
          r = mid;
        }
      }

      return 0;
    }
  }
}
