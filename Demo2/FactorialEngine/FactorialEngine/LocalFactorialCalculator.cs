namespace FactorialEngine
{
    public class LocalFactorialCalculator : ILocalFactorialCalculator
    {
        public int Calculate(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Calculate(n - 1);
        }
    }
}