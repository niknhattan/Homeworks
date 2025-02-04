﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Domain;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnit unit = new Unit() { Name = Measure.MegaByte, Value = 1};

            MeasuresCalculator m = new MeasuresCalculator(unit, KiloMultiplier.k2);

            foreach (var item in m.Units)
            {
                Console.WriteLine("{0} - {1}", item.Name, item.Value);
            }

        }
    }
}
