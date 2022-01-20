using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestPichuginDLL
{
    public class AreaCalculation
    {
        public bool isIsoscelesTriangle = false;

        // Площадь круга
        public string GetAreaInfo(double radius)
        {
            double circleArea = Math.Round(Math.PI, 2) * Math.Pow(radius, 2);

            return "Площадь круга = " + string.Format("{0:F2}", circleArea);
        }

        // Площадь треугольника
        public string GetAreaInfo(double sideA, double sideB, double sideC)
        {
            double semiperimeter = (sideA + sideB + sideC) / 2; // Узнаем полупериметр для вычисления площади
            double triangleArea = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
            
            // Проверяем прямоугольный ли треугольник
            if (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2) || Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2) || Math.Pow(sideC, 2) == Math.Pow(sideB, 2) + Math.Pow(sideA, 2))
            {
                return "Площадь прямоугольного треугольника = " + string.Format("{0:F2}", triangleArea);

            }

            return "Площадь треугольника = " + string.Format("{0:F2}", triangleArea);
        }
    }
}
