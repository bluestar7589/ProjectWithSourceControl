namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Check the method allLuckies
            int[] arr = { 7, 11, 13, 42 };
            Console.WriteLine(allLuckies(arr)); // True
            int[] arr1 = { 7, 12, 13, 33 };
            Console.WriteLine(allLuckies(arr1)); // False

            // Check the method mystery
            int[] value1 = { 1, 2, 3, 5 };
            int[] value2= { 3, 3, 4, 4 };
            int[][] arr2 = { value1,  value2};
            mystery(arr2);
            // print all value in the arr2
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[0].Length; j++)
                {
                    Console.Write(arr2[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Check the method decrementElements
            int[] arr3 = { 1, 2, 3, 4, 5 };
            decrementElements(arr3);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }

        }

        /// <summary>
        /// This method to check if the arr contains all lucky number or not
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Return true if all number in the array is lucky number,
        /// otherwise, return false</returns>
        public static Boolean allLuckies(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 7 && a[i] != 11 && a[i] != 13 && a[i] != 42)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// This method to change the value of the element in the array due to specific condition.
        /// </summary>
        /// <param name="a"></param>
        public static void mystery(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[0].Length - 1; j++)
                {
                    if (a[i][j + 1] > a[i][j]) {
                        a[i][j + 1] *= 2;
                    }
                }
            }
        }

        /// <summary>
        /// This method to decrement all elements in the array by 1
        /// </summary>
        /// <param name="a"></param>
        public static void decrementElements(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] -= 1;
            }
        }
    }
}
