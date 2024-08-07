﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть больше нуля");
            }
            Radius = radius;
        }

        public override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
