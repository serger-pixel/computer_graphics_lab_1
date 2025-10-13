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
            {0, Color.White }, {1, Color.Green }, {2, Color.Coral}, {3, Color.Red}, {4, Color.Blue}
        };

        public Matrix<double> front;
        public Matrix<double> back;
        public Matrix<double> face;
        public Matrix<double> center;
        public Matrix<double> sides;

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
            front[17, 1] = -7;
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

            //Создание матрицы боковой стороны
            sides = new Matrix<double>(0, 0);

            //Создание соединений боковой стороны
            connectionsFrontBack = new List<List<int>>();
            //Верх левого уха
            sides.addRow(new List<double> { back[2, 0], back[2, 1], back[2, 2], 1 });
            sides.addRow(new List<double> { back[1, 0], back[1, 1], back[1, 2], 1 });
            sides.addRow(new List<double> { front[2, 0], front[2, 1], front[2, 2], 1 });
            sides.addRow(new List<double> { front[1, 0], front[1, 1], front[1, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 0, 1, 2, 3 });

            //Верх правого уха
            sides.addRow(new List<double> { back[34, 0], back[34, 1], back[34, 2], 1 });
            sides.addRow(new List<double> { back[33, 0], back[33, 1], back[33, 2], 1 });
            sides.addRow(new List<double> { front[34, 0], front[34, 1], front[34, 2], 1 });
            sides.addRow(new List<double> { front[33, 0], front[33, 1], front[33, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 4, 5, 6, 7 });

            //Макушка
            sides.addRow(new List<double> { back[0, 0], back[0, 1], back[0, 2], 1 });
            sides.addRow(new List<double> { back[35, 0], back[35, 1], back[35, 2], 1 });
            sides.addRow(new List<double> { front[0, 0], front[0, 1], front[0, 2], 1 });
            sides.addRow(new List<double> { front[35, 0], front[35, 1], front[35, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 8, 9, 10, 11 });

            //Левая сторона головы с ушами
            sides.addRow(new List<double> { back[2, 0], back[2, 1], back[2, 2], 1 });
            sides.addRow(new List<double> { front[2, 0], front[2, 1], front[2, 2], 1 });
            sides.addRow(new List<double> { back[4, 0], back[4, 1], back[4, 2], 1 });
            sides.addRow(new List<double> { front[4, 0], front[4, 1], front[4, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 12, 13, 14, 15 });

            //Правая сторона головы с ушами
            sides.addRow(new List<double> { back[33, 0], back[33, 1], back[33, 2], 1 });
            sides.addRow(new List<double> { front[33, 0], front[33, 1], front[33, 2], 1 });
            sides.addRow(new List<double> { back[31, 0], back[31, 1], back[31, 2], 1 });
            sides.addRow(new List<double> { front[31, 0], front[31, 1], front[31, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 16, 17, 18, 19 });

            // Левая внутренняя часть ушей
            sides.addRow(new List<double> { back[1, 0], back[1, 1], back[1, 2], 1 });
            sides.addRow(new List<double> { front[1, 0], front[1, 1], front[1, 2], 1 });
            sides.addRow(new List<double> { back[0, 0], back[0, 1], back[0, 2], 1 });
            sides.addRow(new List<double> { front[0, 0], front[0, 1], front[0, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 20, 21, 22, 23 });

            // Правая внутренняя часть ушей
            sides.addRow(new List<double> { back[34, 0], back[34, 1], back[34, 2], 1 });
            sides.addRow(new List<double> { front[34, 0], front[34, 1], front[34, 2], 1 });
            sides.addRow(new List<double> { back[35, 0], back[35, 1], back[35, 2], 1 });
            sides.addRow(new List<double> { front[35, 0], front[35, 1], front[35, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 24, 25, 26, 27 });

            // Левая нижняя часть головы
            sides.addRow(new List<double> { back[4, 0], back[4, 1], back[4, 2], 1 });
            sides.addRow(new List<double> { back[5, 0], back[5, 1], back[5, 2], 1 });
            sides.addRow(new List<double> { front[4, 0], front[4, 1], front[4, 2], 1 });
            sides.addRow(new List<double> { front[5, 0], front[5, 1], front[5, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 28, 29, 30, 31 });

            // Правая нижняя часть головы
            sides.addRow(new List<double> { back[30, 0], back[30, 1], back[30, 2], 1 });
            sides.addRow(new List<double> { back[31, 0], back[31, 1], back[31, 2], 1 });
            sides.addRow(new List<double> { front[30, 0], front[30, 1], front[30, 2], 1 });
            sides.addRow(new List<double> { front[31, 0], front[31, 1], front[31, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 32, 33, 34, 35 });

            // Левое плечо
            sides.addRow(new List<double> { back[9, 0], back[9, 1], back[9, 2], 1 });
            sides.addRow(new List<double> { back[6, 0], back[6, 1], back[6, 2], 1 });
            sides.addRow(new List<double> { front[9, 0], front[9, 1], front[9, 2], 1 });
            sides.addRow(new List<double> { front[6, 0], front[6, 1], front[6, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 36, 37, 38, 39 });

            // Правое плечо
            sides.addRow(new List<double> { back[29, 0], back[29, 1], back[29, 2], 1 });
            sides.addRow(new List<double> { back[26, 0], back[26, 1], back[26, 2], 1 });
            sides.addRow(new List<double> { front[29, 0], front[29, 1], front[29, 2], 1 });
            sides.addRow(new List<double> { front[26, 0], front[26, 1], front[26, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 40, 41, 42, 43 });

            // Левая ладонь
            sides.addRow(new List<double> { back[10, 0], back[10, 1], back[10, 2], 1 });
            sides.addRow(new List<double> { back[11, 0], back[11, 1], back[11, 2], 1 });
            sides.addRow(new List<double> { front[10, 0], front[10, 1], front[10, 2], 1 });
            sides.addRow(new List<double> { front[11, 0], front[11, 1], front[11, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 44, 45, 46, 47 });

            // Правая ладонь
            sides.addRow(new List<double> { back[24, 0], back[24, 1], back[24, 2], 1 });
            sides.addRow(new List<double> { back[25, 0], back[25, 1], back[25, 2], 1 });
            sides.addRow(new List<double> { front[24, 0], front[24, 1], front[24, 2], 1 });
            sides.addRow(new List<double> { front[25, 0], front[25, 1], front[25, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 48, 49, 50, 51 });

            // Левая подмышка
            sides.addRow(new List<double> { back[12, 0], back[12, 1], back[12, 2], 1 });
            sides.addRow(new List<double> { back[13, 0], back[13, 1], back[13, 2], 1 });
            sides.addRow(new List<double> { front[12, 0], front[12, 1], front[12, 2], 1 });
            sides.addRow(new List<double> { front[13, 0], front[13, 1], front[13, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 52, 53, 54, 55 });

            // Правая подмышка
            sides.addRow(new List<double> { back[22, 0], back[22, 1], back[22, 2], 1 });
            sides.addRow(new List<double> { back[23, 0], back[23, 1], back[23, 2], 1 });
            sides.addRow(new List<double> { front[22, 0], front[22, 1], front[22, 2], 1 });
            sides.addRow(new List<double> { front[23, 0], front[23, 1], front[23, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 56, 57, 58, 59 });

            // Левая сторона шеи
            sides.addRow(new List<double> { back[5, 0], back[5, 1], back[5, 2], 1 });
            sides.addRow(new List<double> { front[5, 0], front[5, 1], front[5, 2], 1 });
            sides.addRow(new List<double> { back[6, 0], back[6, 1], back[6, 2], 1 });
            sides.addRow(new List<double> { front[6, 0], front[6, 1], front[6, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 60, 61, 62, 63 });

            // Правая сторона шеи
            sides.addRow(new List<double> { back[30, 0], back[30, 1], back[30, 2], 1 });
            sides.addRow(new List<double> { front[30, 0], front[30, 1], front[30, 2], 1 });
            sides.addRow(new List<double> { back[29, 0], back[29, 1], back[29, 2], 1 });
            sides.addRow(new List<double> { front[29, 0], front[29, 1], front[29, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 64, 65, 66, 67 });

            // Левая сторона вместе с ногой
            sides.addRow(new List<double> { back[13, 0], back[13, 1], back[13, 2], 1 });
            sides.addRow(new List<double> { front[13, 0], front[13, 1], front[13, 2], 1 });
            sides.addRow(new List<double> { back[15, 0], back[15, 1], back[15, 2], 1 });
            sides.addRow(new List<double> { front[15, 0], front[15, 1], front[15, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 68, 69, 70, 71 });

            // Правая сторона вместе с ногой
            sides.addRow(new List<double> { back[22, 0], back[22, 1], back[22, 2], 1 });
            sides.addRow(new List<double> { front[22, 0], front[22, 1], front[22, 2], 1 });
            sides.addRow(new List<double> { back[20, 0], back[20, 1], back[20, 2], 1 });
            sides.addRow(new List<double> { front[20, 0], front[20, 1], front[20, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 72, 73, 74, 75 });

            // Левая стопа
            sides.addRow(new List<double> { back[15, 0], back[15, 1], back[15, 2], 1 });
            sides.addRow(new List<double> { back[16, 0], back[16, 1], back[16, 2], 1 });
            sides.addRow(new List<double> { front[15, 0], front[15, 1], front[15, 2], 1 });
            sides.addRow(new List<double> { front[16, 0], front[16, 1], front[16, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 76, 77, 78, 79 });

            // Правая стопа
            sides.addRow(new List<double> { back[19, 0], back[19, 1], back[19, 2], 1 });
            sides.addRow(new List<double> { back[20, 0], back[20, 1], back[20, 2], 1 });
            sides.addRow(new List<double> { front[19, 0], front[19, 1], front[19, 2], 1 });
            sides.addRow(new List<double> { front[20, 0], front[20, 1], front[20, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 80, 81, 82, 83 });

            // Нижняя часть тела
            sides.addRow(new List<double> { back[17, 0], back[17, 1], back[17, 2], 1 });
            sides.addRow(new List<double> { back[18, 0], back[18, 1], back[18, 2], 1 });
            sides.addRow(new List<double> { front[17, 0], front[17, 1], front[17, 2], 1 });
            sides.addRow(new List<double> { front[18, 0], front[18, 1], front[18, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 84, 85, 86, 87 });

            // Внутренняя поверхность левой руки
            sides.addRow(new List<double> { back[8, 0], back[8, 1], back[8, 2], 1 });
            sides.addRow(new List<double> { front[8, 0], front[8, 1], front[8, 2], 1 });
            sides.addRow(new List<double> { back[11, 0], back[11, 1], back[11, 2], 1 });
            sides.addRow(new List<double> { front[11, 0], front[11, 1], front[11, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 88, 89, 90, 91 });

            // Внутренняя поверхность правой руки
            sides.addRow(new List<double> { back[27, 0], back[27, 1], back[27, 2], 1 });
            sides.addRow(new List<double> { front[27, 0], front[27, 1], front[27, 2], 1 });
            sides.addRow(new List<double> { back[24, 0], back[24, 1], back[24, 2], 1 });
            sides.addRow(new List<double> { front[24, 0], front[24, 1], front[24, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 92, 93, 94, 95 });

            // Внутренняя поверхность левой ноги
            sides.addRow(new List<double> { back[17, 0], back[17, 1], back[17, 2], 1 });
            sides.addRow(new List<double> { front[17, 0], front[17, 1], front[17, 2], 1 });
            sides.addRow(new List<double> { back[16, 0], back[16, 1], back[16, 2], 1 });
            sides.addRow(new List<double> { front[16, 0], front[16, 1], front[16, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 96, 97, 98, 99 });

            // Внутренняя поверхность правой ноги
            sides.addRow(new List<double> { back[18, 0], back[18, 1], back[18, 2], 1 });
            sides.addRow(new List<double> { front[18, 0], front[18, 1], front[18, 2], 1 });
            sides.addRow(new List<double> { back[19, 0], back[19, 1], back[19, 2], 1 });
            sides.addRow(new List<double> { front[19, 0], front[19, 1], front[19, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 100, 101, 102, 103 });

            // Внешняя поверхность левой руки
            sides.addRow(new List<double> { back[9, 0], back[9, 1], back[9, 2], 1 });
            sides.addRow(new List<double> { front[9, 0], front[9, 1], front[9, 2], 1 });
            sides.addRow(new List<double> { back[10, 0], back[10, 1], back[10, 2], 1 });
            sides.addRow(new List<double> { front[10, 0], front[10, 1], front[10, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 104, 105, 106, 107 });

            // Внешняя поверхность правой руки
            sides.addRow(new List<double> { back[26, 0], back[26, 1], back[26, 2], 1 });
            sides.addRow(new List<double> { front[26, 0], front[26, 1], front[26, 2], 1 });
            sides.addRow(new List<double> { back[25, 0], back[25, 1], back[25, 2], 1 });
            sides.addRow(new List<double> { front[25, 0], front[25, 1], front[25, 2], 1 });
            connectionsFrontBack.Add(new List<int> { 108, 109, 110, 111 });




            //Соединения тела
            connectionsBody = new List<List<int>>();

            connectionsBody.Add(new List<int>() {2, 1, 3, 0}); //Левое ухо
            connectionsBody.Add(new List<int>() { 3, 32, 4, 31 }); // Голова
            connectionsBody.Add(new List<int>() { 5, 30, 6, 29 }); // Шея
            connectionsBody.Add(new List<int>() { 7, 28, 14, 21 }); // Тело
            connectionsBody.Add(new List<int>() { 8, 7, 12, 13 }); // Левое плечо
            connectionsBody.Add(new List<int>() { 9, 8, 10, 11 }); // Левая рука
            connectionsBody.Add(new List<int>() { 14, 17, 15, 16 }); // Левая нога
            connectionsBody.Add(new List<int>() { 18, 21, 19, 20 }); // Правая нога
            connectionsBody.Add(new List<int>() { 27, 26, 24, 25 }); // Правая рука
            connectionsBody.Add(new List<int>() { 28, 27, 22, 23 }); // Правое плечо
            connectionsBody.Add(new List<int>() { 34, 33, 35, 32 }); // Правое ухо

            //Соединения лица
            connectionsFace = new List<List<int>>();

            connectionsFace.Add(new List<int>() { 0, 1, 3, 2 }); // Левый глаз
            connectionsFace.Add(new List<int>() { 5, 4, 6, 7 }); // Правый глаз
            connectionsFace.Add(new List<int>() { 8, 9, 11, 10 }); // Нос

            
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
            sides = sides.multiplyMatrix(matrix);

        }

        public void rotationXY(double a) 
        {
            rotationMatrixXY matrix = new rotationMatrixXY(a);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
            sides = sides.multiplyMatrix(matrix);
        }

        public void rotationXZ(double a)
        {
            rotationMatrixXZ matrix = new rotationMatrixXZ(a);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
            sides = sides.multiplyMatrix(matrix);
        }

        public void rotationYZ(double a)
        {
            rotationMatrixYZ matrix = new rotationMatrixYZ(a);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
            sides = sides.multiplyMatrix(matrix);
        }

        public void zoom(double a, double b, double c)
        {
            dilatationMatrix matrix = new dilatationMatrix(a, b, c);
            front = front.multiplyMatrix(matrix);
            back = back.multiplyMatrix(matrix);
            face = face.multiplyMatrix(matrix);
            center = center.multiplyMatrix(matrix);
            sides = sides.multiplyMatrix(matrix);
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
