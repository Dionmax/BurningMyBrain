class TestParams
{
    public class TestParams
    {
        private double sum = 0;
        public static int somador(params int[] number)
        {
            for (int i = 0; i < number.length; i++)
            {
                sum += number[i];
            }
            return sum;
        }
    }
}