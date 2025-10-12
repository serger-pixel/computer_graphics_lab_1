using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сomputer_graphics_lab
{
    static class GeometryWorker
    {
        //Нахождение k и b из y=kx+b
        public static (double, double) findCoeffLinearEquation(Matrix<double> dots, int indFirst, int indSecond, Plane plane)
        {
            int firstAxis = 0;
            int secondAxis = 1;
            switch (plane)
            {
                case Plane.X:
                    firstAxis = 1;
                    secondAxis = 2;
                    break;
                case Plane.Y:
                    firstAxis = 0;
                    secondAxis = 2;
                    break;
                case Plane.Z:
                    firstAxis = 0;
                    secondAxis = 1;
                    break;
                default: 
                    break;
            }
            double l = dots[indFirst, firstAxis] - dots[indSecond, firstAxis] / (dots[indFirst, secondAxis] - dots[indSecond, secondAxis]);
            double m = dots[indFirst, secondAxis] - l * dots[indFirst, firstAxis];
            return (l, m);
        }

        //Нахождение A, B, C (->n){A, B, C}. ->n - вектор нормаль
        public static Matrix<double> findNormal(Matrix<double> dots, int indFirst, int indSecond, int indThird)
        {
            Matrix<double> result = new Matrix<double>(1, 3);
            double x1 = dots[indFirst, 0];
            double x2 = dots[indSecond, 0];
            double x3 = dots[indThird, 0];
            double y1 = dots[indFirst, 1];
            double y2 = dots[indSecond, 1];
            double y3 = dots[indThird, 1];
            double z1 = dots[indFirst, 2];
            double z2 = dots[indSecond, 2];
            double z3 = dots[indThird, 2];
            double A = (y2 - y1) * (z3 - z1) - (z2 - z1) * (y3 - y1);
            double B = (z2 - z1) * (x3 - x1) - (x2 - x1) * (z3 - z1);
            double C = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);
            result[0, 0] = A;
            result[0, 1] = B;
            result[0, 2] = C;
            return result;
        }

    }
}
