namespace _167._Two_Sum_II___Input_Array_Is_Sorted
{
    internal class Program
    {
        static public int[] TwoSum(int[] numbers, int target)
        {
            int index;
            for (int i = 0; i < numbers.Length; i++)
            {
                index = Array.BinarySearch(numbers, target - numbers[i]);
                if (index > -1)
                {
                    if (i == index) continue;
                    return i > index ?
                            new int[] { index + 1, i + 1 } :
                            new int[] { i + 1, index + 1 };

                    /*return i > Array.BinarySearch(numbers, target - numbers[i]) ?
                            new int[] { Array.BinarySearch(numbers, target - numbers[i]) + 1, i + 1 } :
                            new int[] { i + 1, Array.BinarySearch(numbers, target - numbers[i]) + 1 };*/
                }
                    
            }
            return new int[2];
        }
            static void Main(string[] args)
        {
            int[] nums = new int[]{1, 2, 3, 4, 4, 9, 56, 90};
            Console.WriteLine(TwoSum(nums, 8)[0]);
            Console.WriteLine(TwoSum(nums, 8)[1]);

        }
    }
}