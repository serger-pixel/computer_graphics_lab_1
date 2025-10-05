using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace сomputer_graphics_lab
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

    public class rotationMatrixXY : Matrix<double>
    {
        public rotationMatrixXY(double angle) : base(4, 4)
        {
            double sinAngle = Math.Sin(angle);
            double cosAngle = Math.Cos(angle);
            innerMatrix[0][0] = cosAngle;
            innerMatrix[0][1] = sinAngle;
            innerMatrix[1][0] = -sinAngle;
            innerMatrix[1][1] = cosAngle;
            innerMatrix[2][2] = 1;
            innerMatrix[3][3] = 1;
        }
    }

    public class rotationMatrixXZ : Matrix<double>
    {
        public rotationMatrixXZ(double angle) : base(4, 4)
        {
            double sinAngle = Math.Sin(angle);
            double cosAngle = Math.Cos(angle);
            innerMatrix[0][0] = cosAngle;
            innerMatrix[0][2] = -sinAngle;
            innerMatrix[2][0] = sinAngle;
            innerMatrix[2][2] = cosAngle;
            innerMatrix[1][1] = 1;
            innerMatrix[3][3] = 1;
        }
    }

    public class rotationMatrixYZ : Matrix<double>
    {
        public rotationMatrixYZ(double angle) : base(4, 4)
        {
            double sinAngle = Math.Sin(angle);
            double cosAngle = Math.Cos(angle);
            innerMatrix[0][0] = 1;
            innerMatrix[1][1] = cosAngle;
            innerMatrix[1][2] = sinAngle;
            innerMatrix[2][1] = -sinAngle;
            innerMatrix[2][2] = cosAngle;
            innerMatrix[3][3] = 1;
        }
    }

    public class dilatationMatrix : Matrix<double>
    {
        public dilatationMatrix(double Sx, double Sy, double Sz) : base(4, 4)
        {
            innerMatrix[0][0] = Sx;
            innerMatrix[1][1] = Sy;
            innerMatrix[2][2] = Sz;
            innerMatrix[3][3] = 1;
        }
    }

    public class translationMatrix : Matrix<double>
    {
        public translationMatrix(double Dx, double Dy, double Dz) : base(4, 4)
        {
            innerMatrix[0][0] = 1;
            innerMatrix[1][1] = 1;
            innerMatrix[3][0] = Dx;
            innerMatrix[3][1] = Dy;
            innerMatrix[3][2] = Dz;
            innerMatrix[2][2] = 1;
            innerMatrix[3][3] = 1;
        }
    }

    public class ProjectionMatrixX: Matrix<double>
    {
        public ProjectionMatrixX() : base(4, 4)
        {
            for(int i=1;i<4;i++) innerMatrix[i][i]=1;
        }
    }
    
    public class ProjectionMatrixY: Matrix<double>
    {
        public ProjectionMatrixY() : base(4, 4)
        {
            for(int i=0;i<4;i++) innerMatrix[i][i]=1;
            innerMatrix[1][1] = 0;
        }
    }
    
    public class ProjectionMatrixZ: Matrix<double>
    {
        public ProjectionMatrixZ() : base(4, 4)
        {
            for(int i=0;i<4;i++) innerMatrix[i][i]=1;
            innerMatrix[2][2]=0;
        }
    }

    public class DepthBuffer : Matrix<double>
    {
        public DepthBuffer(Panel paintPanel) : base(paintPanel.Height, paintPanel.Width) 
        {
            for (int i = 0; i < getRows(); i++) 
            {
                for (int j = 0; j < getCols(); j++) 
                {
                    innerMatrix[i][j] = Double.MinValue;
                }
            }
        } 
    }

    public class FrameBuffer : Matrix<double> 
    {
        public FrameBuffer(Panel paintPanel) : base(paintPanel.Height, paintPanel.Width) 
        {
            for (int i = 0; i < getRows(); i++)
            {
                for (int j = 0; j < getCols(); j++)
                {
                    innerMatrix[i][j] = 0;
                }
            }
        }
    }
}
