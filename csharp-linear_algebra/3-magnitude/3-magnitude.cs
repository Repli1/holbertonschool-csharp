using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double sum = 0;

        foreach (double component in vector)
        {
            sum += component * component;
        }

        double result = Math.Sqrt(sum);

        return Math.Round(result, 2);
    }
}
