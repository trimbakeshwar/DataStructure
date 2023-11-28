using DataStructureAndAlgorithem.ArrayandArrayList;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hi");
        ArrayManipulation arrayManipulation = new ArrayManipulation();
        int[] arr = {10,  4, 2, 3, 5, 7,  1 ,9,0,1,2,10,10,3,3};
        int LargestNumber = arrayManipulation.LargestNumber(arr);
        Console.WriteLine("1st large : {0}",LargestNumber);
        Program program = new Program();
        int SecondNumber = arrayManipulation.SecondLargestNumber(arr);
        Console.WriteLine("2nd large : {0}", SecondNumber);
        int smallNumber = arrayManipulation.smallestNumber(arr);
        Console.WriteLine("1st small : {0}", smallNumber);
        int SecondsmallNumber = arrayManipulation.SecondsmallNumber(arr);
        Console.WriteLine("2nd small : {0}", SecondsmallNumber);
        int sumOfArray = arrayManipulation.SumOfArray(arr);
        Console.WriteLine("addition of element in array : {0}", sumOfArray);
        int[] ReverseArr = arrayManipulation.ReverseArray(arr);
        program.DisplayArray("reverse string", ReverseArr);
        int[] result = arrayManipulation.SortFirstHalfAssendingSecondHalfReverse(arr);
        program.DisplayArray("half assending and half descending", result);
        int[] results = arrayManipulation.SortArray(arr);
        program.DisplayArray("sort array", results);
        arrayManipulation.FindFrequencyAndStorInDictionary(arr);
        int[] freqsort = arrayManipulation.SortArrayByFrequency(arr);
        program.DisplayArray("sort by frequency of number array", freqsort);
        int[] newpalidromearr = { 121, 99999,222, 434, 123, 12, 33, 5000000 };
        int LongestPalindrome = arrayManipulation.LogestPalindrome(newpalidromearr);
        Console.WriteLine("Longest palindrom in array {0}", LongestPalindrome);
    }
   public void DisplayArray(string dilog,int[] number)
    {
        Console.WriteLine(dilog);
        for (int i = 0; i < number.Length; i++)
        {

            Console.WriteLine(number[i]);
        }
    }
}