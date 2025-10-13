using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace сomputer_graphics_lab
{
    static class GeometryWorker
    {
        //Нахождение k и b из y=kx+b. l -> k, m -> b
        public static Matrix<double> findCoeffLinearEquation(Matrix<double> dots, int indFirst, int indSecond, Plane plane)
        {
            int firstAxis = 0;
            int secondAxis = 1;
            switch (plane)
            {
                case Plane.X:
                    firstAxis = 2;
                    secondAxis = 1;
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
            double k = dots[indFirst, secondAxis] - dots[indSecond, secondAxis];
            double n = (dots[indFirst, firstAxis] - dots[indSecond, firstAxis]);
            double l = (dots[indFirst, secondAxis] - dots[indSecond, secondAxis]) / (dots[indFirst, firstAxis] - dots[indSecond, firstAxis]);
            if (Math.Abs(dots[indFirst, firstAxis] - dots[indSecond, firstAxis]) <  Math.Pow(10, -5)){
                l = 0;
            }
            double m = dots[indSecond, secondAxis] - l * dots[indSecond, firstAxis];
            Matrix<double> result = new Matrix<double>(0, 0);
            result.addRow(new List<double> { l, m});
            return result;
        }

        //Нахождение длины вектора
        public static double findLenVector(Matrix<double> vector)
        {
            return Math.Sqrt(Math.Pow(vector[0, 0], 2) + Math.Pow(vector[0, 1], 2) + Math.Pow(vector[0, 2], 2));
        }




        //Нахождение суммы площадей треугольников, образованных 4 точками.
        public static double findTriangleSquare(Matrix<double> dots)
        {
            Matrix<double> firstVector = findNormal(dots, 0, 1, 3);
            Matrix<double> secondVector = findNormal(dots, 1, 2, 3);
            Matrix<double> thirdVector = findNormal(dots, 0, 2, 3);
            double firstSquare = 1.0/2 * findLenVector(firstVector);
            double secondSquare = 1.0/2 * findLenVector(secondVector);
            double thirdSquare = 1.0/2 * findLenVector(thirdVector);
            return firstSquare + secondSquare + thirdSquare;

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

        //Нахождение точек внутри треугольника, ограниченного тремя точками
        public static Matrix<double> findTriangleDots(Matrix<double> result, Matrix<double> vectorN, Matrix<double> dots, int first, int second, int third,
                                            Plane plane, int firstAxis, int secondAxis, int cntDots)
        {
            double stepFirstAxis;
            double stepSecondAxis;
            double currentFirstAxis;
            double currentSecondAxis;
            List<List<double>> sortedDots = new List<List<double>> { dots[first], dots[second], dots[third] };

            sortedDots.Sort((a, b) => a[firstAxis].CompareTo(b[firstAxis]));
            currentFirstAxis = sortedDots[0][firstAxis];
            stepFirstAxis = (sortedDots[2][firstAxis] - currentFirstAxis) / cntDots;

            sortedDots.Sort((a, b) => a[secondAxis].CompareTo(b[secondAxis]));
            currentSecondAxis = sortedDots[0][secondAxis];
            stepSecondAxis = (sortedDots[2][secondAxis] - currentSecondAxis) / cntDots;


            double thirdValue = 0;

            double squaredValue = 0;
            for (double a = cntDots; a > 0; a--)
            {
                currentFirstAxis += stepFirstAxis;
                for (double b = cntDots; b > 0; b--)
                {
                    currentSecondAxis += stepSecondAxis;
                    Matrix<double> triangleDots = new Matrix<double>(0, 0);
                    triangleDots.addRow(new List<double> { dots[first, 0], dots[first, 1], dots[first, 2] });
                    triangleDots.addRow(new List<double> { dots[second, 0], dots[second, 1], dots[second, 2] });
                    triangleDots.addRow(new List<double> { dots[third, 0], dots[third, 1], dots[third, 2] });
                    List<double> dot = null;
                    switch (plane)
                    {
                        case Plane.X:
                            thirdValue = -(vectorN[0, 2] * (currentFirstAxis - dots[first, 2]) + vectorN[0, 1] * (currentSecondAxis - dots[first, 1]))/ vectorN[0, 0] + dots[first, 0];
                            dot = (new List<double> { thirdValue, currentSecondAxis, currentFirstAxis });
                            break;
                        case Plane.Y:
                            thirdValue = -(vectorN[0, 0] * (currentFirstAxis - dots[first, 0]) + vectorN[0, 2] * (currentSecondAxis - dots[first, 2]))/ vectorN[0, 1] + dots[first, 1];
                            dot = (new List<double> { currentFirstAxis, thirdValue, currentSecondAxis });
                            break;
                        case Plane.Z:
                            thirdValue = -(vectorN[0, 0] * (currentFirstAxis - dots[first, 0]) + vectorN[0, 1] * (currentSecondAxis - dots[first, 1])) / vectorN[0, 2] + dots[first, 2];
                            dot = (new List<double> { currentFirstAxis, currentSecondAxis, thirdValue });
                            break;
                        default: break;
                    }
                    triangleDots.addRow(dot);
                    double mainSquare = 1.0 / 2 * findLenVector(vectorN);
                    double subSquare = findTriangleSquare(triangleDots);
                    if (Math.Abs(mainSquare - subSquare) < Math.Pow(10, -5))
                    {
                        dot.Add(1.0);
                        result.addRow(dot);
                    }
                }
                currentSecondAxis = sortedDots[0][secondAxis];
            }
            return result;
        }


        //Нахождение всех точек одной стороны рисунка
        // 0 - X, 1 - Y, 2 - Z
        public static Matrix<double> findSideDots(Matrix<double> dots, List<List<int>> connections, int cntDots)
        {
            Matrix<double> result = new Matrix<double>(0, 0);
            for (int i = 0; i < connections.Count; i++) {
                int first = connections[i][0];
                int second = connections[i][1];
                int third = connections[i][2];
                int fourth = connections[i][3];
                Matrix<double> vectorN = findNormal(dots, first, second, third);
                int firstAxis = 0;
                int secondAxis = 1;
                Plane plane = Plane.Z;
                if (((vectorN)[0, 0] < Math.Pow(10, -5) && vectorN[0, 0] > -Math.Pow(10, -5)) &&
                        (vectorN[0, 2] < Math.Pow(10, -5) && vectorN[0, 2] > -Math.Pow(10, -5)))
                {
                    firstAxis = 0;
                    secondAxis = 2;
                    plane = Plane.Y;
                }
                else if (((vectorN)[0, 1] < Math.Pow(10, -5) && vectorN[0, 1] > -Math.Pow(10, -5)) &&
                        (vectorN[0, 2] < Math.Pow(10, -5) && vectorN[0, 2] > -Math.Pow(10, -5)))
                {
                    firstAxis = 2;
                    secondAxis = 1;
                    plane = Plane.X;
                }

                else if (((vectorN)[0, 0] < Math.Pow(10, -5) && vectorN[0, 0] > -Math.Pow(10, -5)) &&
                        (vectorN[0, 1] < Math.Pow(10, -5) && vectorN[0, 1] > -Math.Pow(10, -5)))
                {
                    firstAxis = 0;
                    secondAxis = 1;
                    plane = Plane.Z;
                }

                else if (((vectorN)[0, 0] < Math.Pow(10, -5) && vectorN[0, 0] > -Math.Pow(10, -5)))
                {
                    firstAxis = 0;
                    secondAxis = 1;
                    plane = Plane.Z;
                }

                else if (((vectorN)[0, 1] < Math.Pow(10, -5) && vectorN[0, 1] > -Math.Pow(10, -5)))
                {
                    firstAxis = 0;
                    secondAxis = 1;
                    plane = Plane.Z;
                }

                else if (((vectorN)[0, 2] < Math.Pow(10, -5) && vectorN[0, 2] > -Math.Pow(10, -5)))
                {
                    firstAxis = 2;
                    secondAxis = 1;
                    plane = Plane.X;
                }

                //Первый треугольник
                result = findTriangleDots(result, vectorN, dots, first, second, third, plane, firstAxis, secondAxis, cntDots);

                //Второй треугольник
                result = findTriangleDots(result, vectorN, dots, third, second, fourth, plane, firstAxis, secondAxis, cntDots);
            }
            return result;

        }


    }
}
