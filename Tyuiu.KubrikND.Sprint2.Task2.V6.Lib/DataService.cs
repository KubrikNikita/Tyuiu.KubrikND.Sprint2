using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KubrikND.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3) && (x < 6) && (y >= 3) && (y < 8))
            {
                res = true;
            }
                if ((x >= 6) && (x < 9) && (y >= 5) && (y < 8)) 
            {
                res = true;
            }
                if ((x==9) && (y>=3) && (y<13))
            {
                res = true;
            }
            if ((x == 10) & (y >= 5) && (y < 8))
            {
                res = true;
            }
            if ((x>=6) && (x<9) && (y>=8) && (y<11))
            {
                res = true;
            }
            if ((x >= 3) && (x < 13) && (y == 11))
            {
                res = true;
            }
            if ((x >= 7) && (x < 11) && (y == 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
