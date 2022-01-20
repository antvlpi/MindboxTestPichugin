using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindboxTestPichuginDLL;

namespace MindboxTestPichuginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] valuesArray = Array.ConvertAll(GetNumbers().Split(' '), double.Parse);

            while (valuesArray.Length != 3 && valuesArray.Length != 1)
            {
                Console.WriteLine();
                Console.WriteLine("Введено не верное количество значений. Введите заново!");

                valuesArray = Array.ConvertAll(GetNumbers().Split(' '), double.Parse);
            }

            AreaCalculation shapeArea = new AreaCalculation();
            
            if (valuesArray.Length == 1)
            {
                Console.WriteLine(shapeArea.GetAreaInfo(valuesArray[0]));
            }
            else
            {
                Console.WriteLine(shapeArea.GetAreaInfo(valuesArray[0], valuesArray[1], valuesArray[2]));
            }

            Console.WriteLine("Для выхода нажмите Enter!");
            Console.ReadKey();

        }

        static string GetNumbers()
        {
            Console.WriteLine("Введите 1 числовое значение или 3 через пробел для вычисления площади фигуры:");

            return Console.ReadLine();
        }
    }
}
