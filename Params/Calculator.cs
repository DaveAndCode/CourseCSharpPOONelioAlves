namespace Params
{
    class Calculator
    {
        // Method overload
        public static double Sum(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Sum(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }

        // Vector solution
        // public static double Sum(double[] numbers)
        // {
        //     double sum = 0;
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         sum += numbers[i];
        //     }
        //     return sum;
        // }

        // Params solution
         public static double Sum(params double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}