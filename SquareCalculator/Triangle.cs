using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator
{
    public class Triangle : Figure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRight { get; }

        public Triangle (double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Каждая сторона должна иметь длину больше нуля");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsRight = CheckIsRight(new double[] { sideA, sideB, sideC });
        }

        private bool CheckIsRight(double[] sides)
        {
            //Если треугольник прямоугольный, то наибольшая сторона в нём будет гипотенузой
            double couldBeHypotenuse = sides.Max();
            //В прямоугольном треугольнике квадрат гипотенузы равен сумме квадратов катетов (двух остальных сторон)
            //Тогда сумма двух квадратов гипотенуз будет равна сумме квадратов катетов И квадлрата гипотенузы - то есть, сумме квадратов всех сторон
            return 2*couldBeHypotenuse*couldBeHypotenuse == sides[0] * sides[0] + sides[1] * sides[1] + sides[2] * sides[2];
        }

        public override double CalculateSquare()
        {
            if (this.IsRight)
            {
                //тут можно было бы высчитывать площадь прямоугольного треугольника как полупроизведение катетов
                //но я не уверен, можно ли реализовать алгоритм так, чтобы выигрывать в среднем случае
            }
            //поэтому считаем площадь всегда через полупериметры

            double halfPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }
    }
}
