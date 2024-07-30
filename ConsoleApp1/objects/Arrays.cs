namespace ConsoleApp1.objects;

public class Arrays
{

    public int ee = 5;
   
    
    private void Tset()
    {
        int[] nums1 = new int[4] { 1, 2, 3, 5 };
        int[] nums2 = new int[] { 1, 2, 3, 5 };
        int[] nums3 = new[] { 1, 2, 3, 5 };
        int[] nums4 = { 1, 2, 3, 5 };
        int[] nums5 = [1, 2, 3, 5];
        int[] nums6 = [];

        Console.WriteLine(nums6.Length);
        Console.WriteLine(nums6[^1]);
        Console.WriteLine(nums6[^2]);
        Console.WriteLine(nums6[^3]);
        foreach (int i in nums6)
        {
            Console.WriteLine(i);
        }

        int[,] twoDimNums = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int rows = twoDimNums.GetUpperBound(0) + 1;
        int columns = twoDimNums.Length / rows;
        //OR: int columns = numbers.GetUpperBound(1) + 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{twoDimNums[i, j]} \t");
            }

            Console.WriteLine();
        }

        int[][] arrayOfArrays =
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 1, 2, 3 },
            new int[] { 1, 2, 3, 4, 5 }
        };
    }
}