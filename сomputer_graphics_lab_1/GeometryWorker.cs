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



    }
}
