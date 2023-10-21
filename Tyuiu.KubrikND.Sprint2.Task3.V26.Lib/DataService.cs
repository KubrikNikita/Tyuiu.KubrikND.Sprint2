using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KubrikND.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                y = x + Math.Pow(x + 1 / Math.Pow(Math.Cos(x), 2), x);

            }
            else
                if (x == 0)
            {
                y = (15 + x / 9 - Math.Pow(Math.Sin(x), 2));
            }
            else
            {
                if ((x > -30) && (x < 0))
                {
                    y = Math.Pow((Math.Pow(Math.Sin(x), 3) / x + 5), x);
                }
                else
                {
                    if (x < -30)
                    {
                        y = x + 7 * x - (1 / x);
                    }
                }

            }
            return Math.Round(y, 3);
        }
    }
    }

