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
    }
}
