using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NedospasovaAE.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multiplySeries *= Math.Pow(2 / (Math.Cos(1) + 0.5), i);
            }
            return Math.Round(multiplySeries, 3);
        }
        
    }
}
