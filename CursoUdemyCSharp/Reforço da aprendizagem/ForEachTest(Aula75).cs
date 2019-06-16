namespace ForEachTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 2, 3, 4, 5, 1 };

            foreach (object item in num)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
