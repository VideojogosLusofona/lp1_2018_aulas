using System;
using System.Collections.Generic;

namespace Exercicio4
{
    public class SuperList : List<double>
    {

        public struct MinMax
        {
            public double Min { get; }
            public double Max { get; }
            public MinMax(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public void GetMinMax1(out double min, out double max)
        {
            Sort();
            min = this[0];
            max = this[Count - 1];
        }

        public MinMax GetMinMax2()
        {
            double min, max;
            GetMinMax1(out min, out max);
            return new MinMax(min, max);
        }

        public Tuple<double, double> GetMinMax3()
        {
            double min, max;
            GetMinMax1(out min, out max);
            return new Tuple<double, double>(min, max);
        }
    }
}