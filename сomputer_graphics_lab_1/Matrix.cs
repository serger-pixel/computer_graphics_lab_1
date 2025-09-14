using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace сomputer_graphics_lab_1
{

    public class Matrix<T> where T : INumber<T>
    {
        protected List<List<T>> innerMatrix;

        public int getRows() => innerMatrix.Count;

        public int getCols() => innerMatrix[0].Count;

        public T this[int i, int j]
        {
            get => innerMatrix[i][j];
            set => innerMatrix[i][j] = value;
        }

        public Matrix(int row, int col)
        {
            innerMatrix = new List<List<T>>();
            for (int i = 0; i < row; i++)
            {
                List<T> list = new List<T>(col); 
                for (int j = 0; j < col; j++)
                {
                    list.Add(default(T)); 
                }
                innerMatrix.Add(list);
            }
        }

        public Matrix<T> multiplyMatrix(Matrix<T> subMatrix)
        {
            int controlNum = getCols();
            int rows = getRows();
            int cols = subMatrix.getCols();
            Matrix<T> result = new Matrix<T>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    T sum = default(T);
                    for (int k = 0; k < controlNum; k++)
                    {
                        sum += innerMatrix[i][k] * subMatrix[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
    }

    public class rotationMatrix : Matrix<double>
    {
        public rotationMatrix(double angle) : base(3, 3)
        {
            double sinAngle = Math.Sin(angle);
            double cosAngle = Math.Cos(angle);
            innerMatrix[0][0] = cosAngle;
            innerMatrix[0][1] = sinAngle;
            innerMatrix[0][2] = 0;
            innerMatrix[1][0] = -sinAngle;
            innerMatrix[1][1] = cosAngle;
            innerMatrix[1][2] = 0;
            innerMatrix[2][0] = 0;
            innerMatrix[2][1] = 0;
            innerMatrix[2][2] = 1;

        }
    }

    public class dilatationMatrix : Matrix<double>
    {
        public dilatationMatrix(double a, double b) : base(3, 3)
        {
            innerMatrix[0][0] = a;
            innerMatrix[0][1] = 0;
            innerMatrix[0][2] = 0;
            innerMatrix[1][0] = 0;
            innerMatrix[1][1] = b;
            innerMatrix[1][2] = 0;
            innerMatrix[2][0] = 0;
            innerMatrix[2][1] = 0;
            innerMatrix[2][2] = 1;
        }
    }

    public class translationMatrix : Matrix<double>
    {
        public translationMatrix(double a, double b) : base(3, 3)
        {
            innerMatrix[0][0] = 1;
            innerMatrix[0][1] = 0;
            innerMatrix[0][2] = 0;
            innerMatrix[1][0] = 0;
            innerMatrix[1][1] = 1;
            innerMatrix[1][2] = 0;
            innerMatrix[2][0] = a;
            innerMatrix[2][1] = b;
            innerMatrix[2][2] = 1;
        }
    }
}
