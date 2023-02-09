using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C34MethodOverloadingExercise;
internal class Methods
{

    public static int Add(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    }

    public static decimal Add(decimal num1, decimal num2)
    {
        decimal sum = num1 + num2;
        return sum;
    }

    public static string Add(int num1, int num2, bool isMoney)
    {
        int sum = num1 + num2;
        if (isMoney == true)
        {
            if (sum > 1 || sum < 1)
            {
                return $"{sum} dollars";
            }
            return $"{sum} dollar";
        }
        else
        {
            return $"{sum}";
        }
    }
}
