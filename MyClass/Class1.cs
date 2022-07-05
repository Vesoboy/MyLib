using System;
namespace MyClass
{
    public class MyLib
    {
        //Проверка треугольника на его прямоугольность
        public bool CheckForSquareness(double squareTriangle1, double squareTriangle2, double squareTriangle3)
        {
            if (squareTriangle1 * squareTriangle1 + squareTriangle2 * squareTriangle2 == squareTriangle3 * squareTriangle3)
                return true;
            else return false;
        }


        //Нахождение площади по радиусу круга
        public double SquareRadius(double squareRadius)
        {
            double squ = 3.14 * squareRadius * squareRadius;
            return Math.Round(squ, 3);
        }


        //Нахождение площади по трем сторонам треугольника
        public double SquareTriangle(double squareTriangle1, double squareTriangle2, double squareTriangle3)
        {

            double p = (squareTriangle1 + squareTriangle2 + squareTriangle3) / 2;
                if (p >= 0)
                {
                    double s = Math.Sqrt(p * (p - squareTriangle1) * (p - squareTriangle2) * (p - squareTriangle3));
                return Math.Round(s, 3);
                }
                else return 0;
        }
    }
}