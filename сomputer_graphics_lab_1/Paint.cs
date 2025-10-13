using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace сomputer_graphics_lab
{
    //Перечисления для проекция
    enum Plane
    {
        X,
        Y,
        Z
    }


    class Paint
    {
        public static Dictionary<int, Color> Colors = new Dictionary<int, Color>()
        {
            {0, Color.White }, {1, Color.Green }, {2, Color.Beige}, {3, Color.Red}
        };

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
            front = new Matrix<double>(36, 4);
            for (int i = 0; i < 36; i++)
            {
                front[i, 2] = 4;
                front[i, 3] = 1;
            }
            front[0, 0] = -1;
            front[0, 1] = 14;
            front[1, 0] = -1;
            front[1, 1] = 20;
            front[2, 0] = -3;
            front[2, 1] = 20;
            front[3, 0] = -3;
            front[3, 1] = 14;
            front[4, 0] = -3;
            front[4, 1] = 7;
            front[5, 0] = -1;
            front[5, 1] = 7;
            front[6, 0] = -1;
            front[6, 1] = 5;
            front[7, 0] = -3;
            front[7, 1] = 5;
            front[8, 0] = -5;
            front[8, 1] = 5;
            front[9, 0] = -7;
            front[9, 1] = 5;
            front[10, 0] = -7;
            front[10, 1] = -1;
            front[11, 0] = -5;
            front[11, 1] = -1;
            front[12, 0] = -5;
            front[12, 1] = 3;
            front[13, 0] = -3;
            front[13, 1] = 3;
            front[14, 0] = -3;
            front[14, 1] = -7;
            front[15, 0] = -3;
            front[15, 1] = -13;
            front[16, 0] = -1;
            front[16, 1] = -13;
            front[17, 0] = -1;
            front[17, 1] = -1;
            for (int i = 18; i <= 35; i++)
            {
                front[i, 0] = front[35 - i, 0] * -1;
                front[i, 1] = front[35 - i, 1];
            }

            //Создание задней стороны
            back = new Matrix<double>(36, 4);
            for (int i = 0; i < 36; i++)
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
            for (int i = 0; i < 12; i++)
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

            connectionsBody.Add(new List<int>() {2, 1, 3, 0}); //Левое ухо
            //connectionsBody.Add(new List<int>() {3, 32, 4, 31}); // Голова
            //connectionsBody.Add(new List<int>() {5, 30, 6, 29}); // Шея
            //connectionsBody.Add(new List<int>() {7, 28, 14, 21}); // Тело
            //connectionsBody.Add(new List<int>() {8, 7, 12, 13}); // Левое плечо
            //connectionsBody.Add(new List<int>() {9, 8, 10, 11}); // Левая рука
            //connectionsBody.Add(new List<int>() {14, 17, 15, 16}); // Левая нога
            //connectionsBody.Add(new List<int>() {18, 21, 19, 20}); // Правая нога
            //connectionsBody.Add(new List<int>() {27, 26, 24, 25}); // Правая рука
            //connectionsBody.Add(new List<int>() {28, 27, 22, 23}); // Правое плечо
            //connectionsBody.Add(new List<int>() {34, 33, 35, 32}); // Правое ухо

            //Соединения лица
            connectionsFace = new List<List<int>>();

            connectionsFace.Add(new List<int>() { 0, 1, 3, 2 }); // Левый глаз
            connectionsFace.Add(new List<int>() { 5, 4, 6, 7 }); // Правый глаз
            connectionsFace.Add(new List<int>() { 8, 9, 11, 10 }); // Нос

            //Соединения передней и задней стороны
            connectionsFrontBack = new List<List<int>>();

            for (int i = 1; i < 3; i++) // Грани ушей
            {
                connectionsFrontBack.Add(new List<int>() { i, i, i+1, i+1 });
                connectionsFrontBack.Add(new List<int>() { i+32, i+32, i+33, i+33 });
            }
            connectionsFrontBack.Add(new List<int>() { 1, 1, 0, 0 }); // Левое ухо справа
            connectionsFrontBack.Add(new List<int>() { 33, 33, 32, 32 }); //Правое ухо справа

            connectionsFrontBack.Add(new List<int>() { 3, 3, 4, 4 }); // Голова слева
            connectionsFrontBack.Add(new List<int>() { 4, 4, 31, 31 }); // Голова снизу
            connectionsFrontBack.Add(new List<int>() { 32, 32, 31, 31 }); // Голова справа
            connectionsFrontBack.Add(new List<int>() { 32, 32, 3, 3 }); // Голова сверху

            connectionsFrontBack.Add(new List<int>() { 5, 5, 6, 6 }); // Шея слева
            connectionsFrontBack.Add(new List<int>() { 30, 30, 29, 29 }); // Шея справа

            connectionsFrontBack.Add(new List<int>() { 7, 7, 14, 14 }); // Тело слева
            connectionsFrontBack.Add(new List<int>() { 21, 21, 14, 14 }); // Тело снизу
            connectionsFrontBack.Add(new List<int>() { 28, 28, 21, 21 }); // Тело справа
            connectionsFrontBack.Add(new List<int>() { 28, 28, 7, 7 }); // Тело сверху

            connectionsFrontBack.Add(new List<int>() { 7, 7, 8, 8 }); // Левое плечо сверху
            connectionsFrontBack.Add(new List<int>() { 13, 13, 12, 12 }); // Левое плечо снизу

            connectionsFrontBack.Add(new List<int>() { 27, 27, 28, 28 }); // Правое плечо сверху
            connectionsFrontBack.Add(new List<int>() { 23, 23, 22, 22 }); // Правое плечо снизу

            for (int i = 8; i < 10; i++) // Грани левой руки
            {
                connectionsFrontBack.Add(new List<int>() { i, i, i+1, i+1 }); 
            }
            connectionsFrontBack.Add(new List<int>() { 11, 11, 10, 10 }); // Левая рука снизу
            connectionsFrontBack.Add(new List<int>() { 8, 8, 11, 11 }); // Левая рука справа

            connectionsFrontBack.Add(new List<int>() { 17, 17, 14, 14 }); // Левая нога сверху
            connectionsFrontBack.Add(new List<int>() { 14, 14, 15, 15 }); // Левая нога слева
            connectionsFrontBack.Add(new List<int>() { 16, 16, 15, 15 }); // Левая нога снизу
            connectionsFrontBack.Add(new List<int>() { 17, 17, 16, 16 }); // Левая нога справа

            connectionsFrontBack.Add(new List<int>() { 21, 21, 18, 18 }); // Правая нога сверху
            connectionsFrontBack.Add(new List<int>() { 18, 18, 19, 19 }); // Правая нога слева
            connectionsFrontBack.Add(new List<int>() { 20, 20, 19, 19 }); // Правая нога снизу
            connectionsFrontBack.Add(new List<int>() { 21, 21, 20, 20 }); // Правая нога справа

            connectionsFrontBack.Add(new List<int>() { 26, 26, 27, 27 }); // Правая сверху
            connectionsFrontBack.Add(new List<int>() { 25, 25, 24, 24 }); // Правая рука снизу
            connectionsFrontBack.Add(new List<int>() { 26, 26, 25, 25 }); // Правая рука справа
            connectionsFrontBack.Add(new List<int>() { 27, 27, 24, 24 }); // Правая рука слева

        }

        static public Matrix<double> transformMatrix(Panel paintPanel, Matrix<double> matrix)
        {
            Matrix<double> result = new Matrix<double>(matrix.getRows(), matrix.getCols());
            const int zoomPix = 10;
            for (int i = 0; i < matrix.getRows(); i++)
            {
                result[i, 0] = (int)(paintPanel.Width / 2 + zoomPix * matrix[i, 0]) + 1;
                if (result[i, 0] < 0)
                {
                    result[i, 0] = 0;
                }
                result[i, 1] = (int)(paintPanel.Height / 2 - zoomPix* matrix[i, 1]) + 1;
                if (result[i, 1] < 0)
                {
                    result[i, 1] = 0;
                }
                result[i, 2] = matrix[i, 2];


            }
            return result;
        }


        //Перевод из мировых в экранные координаты в зависимости от плоскости
        static public Matrix<double>? transformPrMatrix(Panel paintPanel, Matrix<double> matrix, Plane p)
        {
            Matrix<double> result = new Matrix<double>(matrix.getRows(), matrix.getCols());
            const int zoomPix = 10;
            switch (p)
            {
                case Plane.X:
                    for (int i = 0; i < matrix.getRows(); i++)
                    {
                        result[i, 0] = matrix[i, 0];
                        result[i, 1] = (int)(paintPanel.Height / 2 - zoomPix * matrix[i, 1]) + 1;
                        result[i, 2] = (int)(paintPanel.Width / 2 + zoomPix * matrix[i, 2]) + 1;
                    }
                    break;
                case Plane.Y:
                    for (int i = 0; i < matrix.getRows(); i++)
                    {
                        result[i, 0] = (int)(paintPanel.Width / 2 + zoomPix * matrix[i, 0]) + 1;
                        result[i, 1] = matrix[i, 1];
                        result[i, 2] = (int)(paintPanel.Height / 2 - zoomPix * matrix[i, 2]) + 1;
                    }
                    break;
                case Plane.Z:
                    result = transformMatrix(paintPanel, matrix);
                    break;
                default: break;
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

        public (Matrix<double>, Matrix<double>, Matrix<double>) ProjectOnX()
        {
            ProjectionMatrixX matrixX = new ProjectionMatrixX();
            Matrix<double> FrontProjection = front.multiplyMatrix(matrixX);
            Matrix<double> BackProjection = back.multiplyMatrix(matrixX);
            Matrix<double> FaceProjection = face.multiplyMatrix(matrixX);
            return (FrontProjection, BackProjection, FaceProjection);
        }
    }
}
