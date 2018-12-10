using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {/// <summary>
    /// Функция получает число и возвращает десятичные числа в числовом интервале
    /// </summary>
    /// <param name="number">конечное число</param>
    /// <returns></returns>
        public IEnumerable<int> GetDecimalNumbers(int number)
        {
            for (int i = 1; i<= number; i++)
            {
                if (i % 10 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
