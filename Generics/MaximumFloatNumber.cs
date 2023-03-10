namespace Generics
{
    internal class MaximumFloatNumber
    {
        public static float FindMaxValue(float first, float second, float third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                //Console.WriteLine("{0} is maximum number among {1} {2} {3}", first, first, second, third);
                return first;

            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                //Console.WriteLine("{0} is maximum number among {1} {2} {3}", second, first, second, third);
                return second;

            else
                //Console.WriteLine("{0} is maximum number among {1} {2} {3}", third, first, second, third);
                return third;
        }
    }
}
