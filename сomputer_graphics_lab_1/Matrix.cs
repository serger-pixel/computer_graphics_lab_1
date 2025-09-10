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

        public Matrix(int row, int col) {
            innerMatrix = new List<List<T>>();
            for (int i = 0; i < row; i++)
            {
                innerMatrix.Add(new List<T>(col));
            }
        }

        public Matrix<T> multiplyMatrix(Matrix<T> subMatrix) {
            int controlNum = getCols();
            int rows = getRows();
            int cols = subMatrix.getCols();
            Matrix<T> result = new Matrix<T>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    T sum = default(T);
                    for (int k = 0; k <controlNum; k++)
                    {
                        sum += innerMatrix[i][k] * subMatrix[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

    public class rotationMatrix: Matrix
    {
        public rotationMatrix(double angle) 
        {
            double sinAngle = Math.Sin(angle);
            double cosAngle = Math.Cos(angle);

        }
    }
}
