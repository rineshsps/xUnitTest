namespace CalculatorService
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            if (first == 1)
            {
                return first * first;
            }

            if (first == second)
            {
                return second * second;
            }
            return first + second;
        }

        public int Mutiplication(int first, int second)
        {
            return first * second;
        }
    }
}
