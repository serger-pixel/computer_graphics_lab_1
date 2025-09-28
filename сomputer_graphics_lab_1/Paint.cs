using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace сomputer_graphics_lab_1
{
    class Paint
    {
        public Matrix<double> front;
        public Matrix<double> back;
        public Matrix<double> face;
        public Matrix<double> center;

        public List<List<int>> connectionsBody;
        public List<List<int>> connectionsFace;
        public List<List<int>> connectionsFrontBack;
        

        public Paint()
        {
            //Создание передней стороны
            front = new Matrix<double>(28, 4);
            for(int i = 0; i < 28; i++) 
            {
                front[i, 2] = 4;
                front[i, 3] = 1;
            }
            front[0, 0] = -1;
            front[0, 1] = 20;
            front[1, 0] = -3;
            front[1, 1] = 20;
            front[2, 0] = -3;
            front[2, 1] = 7;
            front[3, 0] = -1;
            front[3, 1] = 7;
            front[4, 0] = -1;
            front[4, 1] = 5;
            front[5, 0] = -7;
            front[5, 1] = 5;
            front[6, 0] = -7;
            front[6, 1] = -1;
            front[7, 0] = -5;
            front[7, 1] = -1;
            front[8, 0] = -5;
            front[8, 1] = 3;
            front[9, 0] = -3;
            front[9, 1] = 3;
            front[10, 0] = -3;
            front[10, 1] = -12;
            front[11, 0] = -1;
            front[11, 1] = -12;
            front[12, 0] = -1;
            front[12, 1] = -7;
            front[26, 0] = 1;
            front[26, 1] = 14;
            front[27, 0] = -1;
            front[27, 1] = 14;
            for (int i = 13; i < 26; i++)
            {
                front[i, 0] = front[25 - i, 0] * -1;
                front[i, 1] = front[25 - i, 1];
            }

            //Создание задней стороны
            back = new Matrix<double>(28, 4);
            for (int i = 0; i < 28; i++)
            {
                back[i, 0] = front[i, 0];
                back[i, 1] = front[i, 1];
                back[i, 2] = front[i, 2] * -1;
                back[i, 3] = front[i, 3];
            }

            //Создание центра
            center = new Matrix<double>(1, 4);
            center[0, 0] = 0;
            center[0, 1] = 0;
            center[0, 2] = 0;
            center[0, 3] = 1;

            //Создание лица
            face = new Matrix<double>(12, 4);
            for(int i = 0; i < 12; i++) 
            {
                face[i, 2] = 4;
                face[i, 3] = 1;
            }
            face[0, 0] = -3;
            face[0, 1] = 12;
            face[1, 0] = -1;
            face[1, 1] = 12;
            face[2, 0] = -1;
            face[2, 1] = 11;
            face[3, 0] = -3;
            face[3, 1] = 11;
            for(int i = 4; i < 8; i++)
            {
                face[i, 0] = -face[i - 4, 0];
                face[i, 1] = face[i - 4, 1];
            }
            face[8, 0] = -1;
            face[8, 1] = 10;
            face[9, 0] = 1;
            face[9, 1] = 10;
            face[10, 0] = 1;
            face[10, 1] = 9;
            face[11, 0] = -1;
            face[11, 1] = 9;

            //Соединения тела
            connectionsBody = new List<List<int>>();
            for (int i = 0; i < 27; i++)
            {
                connectionsBody.Add(new List<int>(){i, i+1});
            }
            connectionsBody.Add(new List<int>() { 27, 0 });

            //Соединения лица
            connectionsFace = new List<List<int>>();
            for (int i = 0;  i < 11; i++)
            {
                if (i % 4 == 3) { continue; }
                connectionsFace.Add(new List<int>() { i, i + 1 });
            }
            connectionsFace.Add(new List<int>() { 8, 11 });

            //Соединения передней и задней стороны
            connectionsFrontBack = new List<List<int>>();
            for (int i = 0; i < 27; i++)
            {
                connectionsFrontBack.Add(new List<int>() { i, i});
            }

        }

        public Matrix<double> transformMatrix(Panel paintPanel, Matrix<double> matrix)
        {
            Matrix<double> result = new Matrix<double>(matrix.getRows(), matrix.getCols());
            const int zoomPix = 10;
            for (int i = 0; i < matrix.getRows(); i++)
            {
                result[i, 0] = paintPanel.Width / 2 + zoomPix * matrix[i, 0];
                result[i, 1] = paintPanel.Height / 2 - zoomPix* matrix[i, 1];
                result[i, 2] = zoomPix * matrix[i, 2];
                result[i, 3] = 1;
            }
            return result;
        }
        public List<double> getCenter()
        {
            return new List<double>() { center[0, 0], center[0, 1], center[0, 2], center[0, 3]  };
        }

        public void move(double a, double b, double c)
        {
            translationMatrix matrix = new translationMatrix(a, b, c);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
            center = center.multiplyMatrix(matrix);

        }

        public void rotationXY(double a) 
        {
            rotationMatrixXY matrix = new rotationMatrixXY(a);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
        }

        public void rotationXZ(double a)
        {
            rotationMatrixXZ matrix = new rotationMatrixXZ(a);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
        }

        public void rotationYZ(double a)
        {
            rotationMatrixYZ matrix = new rotationMatrixYZ(a);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
        }

        public void zoom(double a, double b, double c)
        {
            dilatationMatrix matrix = new dilatationMatrix(a, b, c);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
            center = center.multiplyMatrix(matrix);
        }

        public (Matrix<double>, Matrix<double>) ProjectOnX()
        {
            ProjectionMatrixX matrixX = new ProjectionMatrixX();
            Matrix<double> FaceProjection = front.multiplyMatrix(matrixX);
            Matrix<double> BackProjection = back.multiplyMatrix(matrixX);
            return (FaceProjection, BackProjection);
        }

        public void ProjectOnY()
        {
        }

        public void ProjectOnZ()
        {
        }
    }
}
