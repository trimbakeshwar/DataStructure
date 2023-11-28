using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithem.ArrayandArrayList
{
    public class ArrayManipulation
    {
        public int LargestNumber(int[] arr)
        {
            int FirstLargest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (FirstLargest < arr[i])
                {
                    FirstLargest = arr[i];
                }
            }
            return FirstLargest;
        }
        public int smallestNumber(int[] arr)
        {
            int Firstsmall = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Firstsmall > arr[i])
                {
                    Firstsmall = arr[i];
                }
            }
            return Firstsmall;
        }
        public int SecondLargestNumber(int[] arr)
        {
            int FirstLargest = 0;
            int secondLargest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (FirstLargest < arr[i])
                {
                    secondLargest = FirstLargest;
                    FirstLargest = arr[i];
                }
                else if (secondLargest < arr[i])
                {
                    secondLargest = arr[i];
                }
            }
            return secondLargest;


        }
        public int SecondsmallNumber(int[] arr)
        {
            int FirstSmall = arr[0];
            int secondSmall = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (FirstSmall > arr[i])
                {
                    secondSmall = FirstSmall;
                    FirstSmall = arr[i];
                }
                else if (secondSmall > arr[i])
                {
                    secondSmall = arr[i];
                }
            }
            return secondSmall;
        }
        //Calculate the sum of elements in an array 

        public int SumOfArray(int[] arr)
        {
            int SumOfNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                SumOfNumber += arr[i];
            }
            return SumOfNumber;
        }
        //Reverse an Array
        public int[] ReverseArray(int[] arr)
        {
            int[] newarr = new int[arr.Length];
            int j = 0;
            for(int i=arr.Length-1; i>=0; i--)
            {
                newarr[j++] = arr[i];
            }
            return newarr;
        }
        //Sort first half in ascending order and second half in descending :
        public int[] SortFirstHalfAssendingSecondHalfReverse(int[] arr)
        {
            
            int half = arr.Length / 2;
            for(int i = 0;i < half; i++)
            {
                for(int j=0; j < half; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            for (int i = half; i < arr.Length; i++)
            {
                for (int j = half; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
        //Sort the elements of an array :
        public int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] >arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
        //Finding the frequency of elements in an array
        public Dictionary<int, int> FindFrequencyAndStorInDictionary(int[] arr)
        {
            Dictionary<int,int>DataDisc=new Dictionary<int,int>();
            for(int i = 0;i < arr.Length; i++)
            {
                if (DataDisc.ContainsKey(arr[i]))
                {
                    DataDisc[arr[i]]++;
                }
                else
                {
                    DataDisc[arr[i]] = 1;
                }
            }
            foreach(var i in DataDisc)
            {
                Console.WriteLine(i);
            }
            return DataDisc;
        }

        public List<KeyValuePair<int, int>> SortedDictionary(Dictionary<int, int> Dictionarys)

        {
            var myList = Dictionarys.ToList();

            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            return myList;
        }
        //Sorting elements of an array by frequency
        public int[] SortArrayByFrequency(int[] arr)
        {
            
            List<KeyValuePair<int, int>> DataDisc = SortedDictionary(FindFrequencyAndStorInDictionary(arr));
            int[] NewArray = new int[arr.Length];
            int higestfrequency = DataDisc.ElementAt(0).Value;
            int k = 0;
            for(int i = DataDisc.Count-1; i >= 0; i--)
            {
                var count = DataDisc.ElementAt(i).Value;
                for(int j = 0; j < count; j++)
                {
                    NewArray[k++] = DataDisc.ElementAt(i).Key;
                }
            }

            return NewArray;
        }
        //Finding the Longest Palindrome in an Array
        public bool isPalindrome(int element)
        {
            int n, r, sum = 0, temp;
            n = element;
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                return true;
            else
                return false;
        }
        public int LogestPalindrome(int[] arr)
        {
            int LongestNumberPalindrome = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (isPalindrome(arr[i]))
                {
                    if (LongestNumberPalindrome < arr[i])
                    {
                        LongestNumberPalindrome = arr[i];
                    }
                }
            }
            return LongestNumberPalindrome;
        }
    }
}
