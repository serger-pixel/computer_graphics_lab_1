using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сomputer_graphics_lab_1
{
    
    public class Matrix<T>
    {
        protected List<List<T>> innerMatrix;

        public int getRows() => innerMatrix.Count;

        public int getCols() => innerMatrix[0].Count;
      
        protected Matrix(int row, int col) {
            innerMatrix = new List<List<T>>();
            for (int i = 0; i < row; i++)
            {
                innerMatrix.Add(new List<T>(col));
            }
        }

        public Matrix<int> multiplyMatrix(Matrix<T> subMatrix) {
            int controlNum = getCols();
            int rows = getCols();
            int cols = subMatrix.getRows();
            Matrix<int> result = new Matrix<int>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                     
                }
            }
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
