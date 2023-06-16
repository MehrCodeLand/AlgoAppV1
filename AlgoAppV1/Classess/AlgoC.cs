using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAppV1.Classess
{
    public class AlgoC
    {

        public static void BubbleSort(int[] nums )
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length -1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
        public static void LinearSearch(int number , int[] nums)
        {
            for(int i= 0; i < nums.Length; ++i)
            {
                if(number == nums[i])
                {
                    Console.WriteLine("Found!\n" +
                        $"index-> {i}");
                    break;
                }   
            }
        }
        public static int BinarySearch(int[] nums , int left , int right , int number)
        {
            while(left <= right)
            {
                //پیدا کردن وسط داده ها 
                int index = left + (right - left) / 2;

                if (nums[index] == number)
                    return index;

                // اکر عدد کوچک تر بود
                if (nums[index] > number)
                    left = index + 1;

                // اکه عدد بزرگ تر بود
                else
                    left = index - 1;
            }

            // داده پیدا نشد
            return -10;
        }
        public static void SelectionSort(int[] nums)
        {
            for(int i = 0; i < nums.Length; ++i)
            {
                var smallestValIndex = i;

                for(int j = i + 1; j < nums.Length; ++j)
                {
                    if (nums[j] < nums[smallestValIndex])
                    {
                        smallestValIndex = j;
                    }
                }

                var tepVal = nums[smallestValIndex];
                nums[smallestValIndex] = nums[i];
                nums[i] = tepVal;
            }
        }



        // mergeSort
        public static void MergeSortMain(int[] nums , int left , int right) 
        {
            if(left < right)
            {
                int index = left + (right - left) / 2;

                MergeSortMain(nums, left, index);
                MergeSortMain(nums, index + 1 , right);



            }
        }

        public static void Merge(int[] nums , int left , int index , int right)
        {

        }


    }
}
