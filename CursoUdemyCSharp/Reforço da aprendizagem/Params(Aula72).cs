public class Program
{
    public static void Main()
    {
        System.Console.WriteLine(TestParams.somador(2, 3, 4, 5, 6));
    }

    class TestParams
    {
        private static int sum = 0;

        public static int somador(params int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }
    }
}