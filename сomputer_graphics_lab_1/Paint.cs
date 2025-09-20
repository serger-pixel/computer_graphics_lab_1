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
        private Matrix<double> coords;

        public List<List<int>> connections;

        private Graphics g;
        Pen pen = new Pen(Color.Black, 2);


        public Paint()
        {
            coords = new Matrix<double>(70, 4);

            for(int i = 0; i < 41; i++) 
            {
                coords[i, 3] = 4;
            }

            // Точки задней стороны
            for (int i = 0, j = 41; i < 41; i++, j++)
            {
                if (i == 17 || i == 18 || i == 37 || i == 38 
                   || i == 16 || i == 36 || i == 2 || i == 5 || i == 22 || i == 25 || i == 0)
                {
                    continue;
                }

                coords[j, 0] = coords[i, 0];
                coords[j, 1] = coords[i, 1];
                coords[j, 2] = -coords[i, 2];
                coords[j, 3] = 1;
            }


            coords[0, 0] = -1;
            coords[0, 1] = 20;
            coords[0, 2] = 1;
            coords[1, 0] = -3;
            coords[1, 1] = 20;
            coords[1, 2] = 1;
            coords[2, 0] = -3;
            coords[2, 1] = 12;
            coords[2, 2] = 1;
            coords[3, 0] = -1;
            coords[3, 1] = 12;
            coords[3, 2] = 1;
            coords[4, 0] = -1;
            coords[4, 1] = 11;
            coords[4, 2] = 1;
            coords[5, 0] = -3;
            coords[5, 1] = 11;
            coords[5, 2] = 1;
            coords[6, 0] = -3;
            coords[6, 1] = 7;
            coords[6, 2] = 1;
            coords[7, 0] = -1;
            coords[7, 1] = 7;
            coords[7, 2] = 1;
            coords[8, 0] = -1;
            coords[8, 1] = 5;
            coords[8, 2] = 1;
            coords[9, 0] = -7;
            coords[9, 1] = 5;
            coords[9, 2] = 1;
            coords[10, 0] = -7;
            coords[10, 1] = -1;
            coords[10, 2] = 1;
            coords[11, 0] = -5;
            coords[11, 1] = -1;
            coords[11, 2] = 1;
            coords[12, 0] = -5;
            coords[12, 1] = 3;
            coords[12, 2] = 1;
            coords[13, 0] = -3;
            coords[13, 1] = 3;
            coords[13, 2] = 1;
            coords[14, 0] = -3;
            coords[14, 1] = -12;
            coords[14, 2] = 1;
            coords[15, 0] = -1;
            coords[15, 1] = -12;
            coords[15, 2] = 1;
            coords[16, 0] = -1;
            coords[16, 1] = -7;
            coords[16, 2] = 1;
            coords[17, 0] = -1;
            coords[17, 1] = 9;
            coords[17, 2] = 1;
            coords[18, 0] = -1;
            coords[18, 1] = 10;
            coords[18, 2] = 1;
            coords[19, 0] = -1;
            coords[19, 1] = 14;
            coords[19, 2] = 1;
            for (int i = 20; i < 40; i++)
            {
                coords[i, 0] = coords[i - 20, 0] * -1;
                coords[i, 1] = coords[i - 20, 1];
                coords[i, 2] = 1;
            }
            coords[40, 0] = 0;
            coords[40, 1] = 0;
            coords[40, 2] = 0;
            coords[40, 3] = 1;


            connections = new List<List<int>>();
            for (int i = 0; i < 40; i++)
            {
                if (i == 17 || i == 18 || i == 19 || i == 37 || i == 38 || i == 39 
                    || i == 16 || i == 36)
                {
                    continue;
                }
                connections.Add(new List<int> { i, i + 1 });
            }
            connections.Add(new List<int>() { 17, 18 });
            connections.Add(new List<int>() { 18, 38 });
            connections.Add(new List<int>() { 38, 37 });
            connections.Add(new List<int>() { 37, 17 });
            connections.Add(new List<int>() { 19, 39 });
            connections.Add(new List<int>() { 16, 36 });
            connections.Add(new List<int>() { 2, 5 });
            connections.Add(new List<int>() { 22, 25 });
            connections.Add(new List<int>() { 20, 39 });
            connections.Add(new List<int>() { 0, 19 });

            for (int i = 41; i < 69; i++) 
            {
                connections.Add(new List<int> { i, i + 1 });
            }

            for (int i = 0, step = 41; i < 18; i++) 
            {
                if (i == 2) { step = 37; i = 5; continue; }
                connections.Add(new List<int>() { i, i + step });
            }

            for (int i = 20, step = 41; i < 36; i++) 
            {
                if (i == 22) { step = 37; i = 25; continue; }
                connections.Add(new List<int>() { i, i + step });
            }

            connections.Add(new List<int>() { 19, 54 });
            connections.Add(new List<int>() { 39, 69 });
        }

        public Matrix<double> transformMatrix(Panel paintPanel)
        {
            Matrix<double> result = new Matrix<double>(coords.getRows(), coords.getCols());
            const int zoomPix = 10;
            for (int i = 0; i < coords.getRows(); i++)
            {
                result[i, 0] = paintPanel.Width / 2 + zoomPix * coords[i, 0];
                result[i, 1] = paintPanel.Height / 2 - zoomPix* coords[i, 1];
                result[i, 2] = 1;
            }
            return result;
        }
        public List<double> getCenter()
        {
            return new List<double>() { coords[40, 0], coords[40, 1], coords[40, 2] };
        }

        public void move(double a, double b, double c)
        {
            translationMatrix matrix = new translationMatrix(a, b, c);
            coords = coords.multiplyMatrix(matrix);
        }

        public void rotationXY(double a) 
        {
            rotationMatrixXY matrix = new rotationMatrixXY(a);
            coords = coords.multiplyMatrix(matrix);
        }

        public void rotationXZ(double a)
        {
            rotationMatrixXZ matrix = new rotationMatrixXZ(a);
            coords = coords.multiplyMatrix(matrix);
        }

        public void rotationYZ(double a)
        {
            rotationMatrixYZ matrix = new rotationMatrixYZ(a);
            coords = coords.multiplyMatrix(matrix);
        }

        public void zoom(double a, double b, double c)
        {
            dilatationMatrix matrix = new dilatationMatrix(a, b, c);
            coords = coords.multiplyMatrix(matrix);
        }
    }
}
