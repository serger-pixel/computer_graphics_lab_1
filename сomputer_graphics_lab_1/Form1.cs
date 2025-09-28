using System.Collections.Generic;
using System.Drawing;

namespace сomputer_graphics_lab_1
{
    public partial class Form1 : Form
    {
        Graphics g;
        private Pen pen;
        Paint rabbit = new Paint();

        private void paintDots(List<List<int>> connections, Matrix<double> dots, Graphics g, Pen pen)
        {
            Matrix<double> displayMatrix = rabbit.transformMatrix(paintPanel, dots);
            for (int i = 0; i < connections.Count; i++)
            {
                int x1 = (int)displayMatrix[connections[i][0], 0] + 1;
                int y1 = (int)displayMatrix[connections[i][0], 1] + 1;
                int x2 = (int)displayMatrix[connections[i][1], 0] + 1;
                int y2 = (int)displayMatrix[connections[i][1], 1] + 1;
                g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        private void paintDots(List<List<int>> connections, Matrix<double> dots1, Matrix<double> dots2, Graphics g, Pen pen)
        {
            Matrix<double> displayMatrix1 = rabbit.transformMatrix(paintPanel, dots1);
            Matrix<double> displayMatrix2 = rabbit.transformMatrix(paintPanel, dots2);
            for (int i = 0; i < connections.Count; i++)
            {
                int x1 = (int)displayMatrix1[connections[i][0], 0] + 1;
                int y1 = (int)displayMatrix1[connections[i][0], 1] + 1;
                int x2 = (int)displayMatrix2[connections[i][1], 0] + 1;
                int y2 = (int)displayMatrix2[connections[i][1], 1] + 1;
                g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            pen = new Pen(Color.Blue, 5);
            paintDots(rabbit.connectionsBody, rabbit.front, g, pen);
            paintDots(rabbit.connectionsBody, rabbit.back, g, pen);
            paintDots(rabbit.connectionsFace, rabbit.face, g, pen);
            paintDots(rabbit.connectionsFrontBack, rabbit.front, rabbit.back, g, pen);
        }

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            paintPanel.Paint += Form1_Paint;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            String text = null;
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    text = rb.Text;
                }
            }
            switch (text)
            {
                case "X":
                    rabbit.move(10, 0, 0);
                    break;
                case "Y":
                    rabbit.move(0, 10, 0);
                    break;
                case "Z":
                    rabbit.move(0, 0, 10);
                    break;
                default:
                    break;
            }
            paintPanel.Invalidate();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            String text = null;
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    text = rb.Text;
                }
            }
            switch (text) 
            {
                case "X":
                    rabbit.move(-10, 0, 0);
                    break;
                case "Y":
                    rabbit.move(0, -10, 0);
                    break;
                case "Z":
                    rabbit.move(0, 0, -10);
                    break;
                default:
                   break; 
            }
            paintPanel.Invalidate();
        }

        private void rotationLeft_Click(object sender, EventArgs e)
        {
            String text = null;
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    text = rb.Text;
                }
            }
            List<double> center = rabbit.getCenter();
            rabbit.move(center[0] * -1, center[1] * -1, center[2] * -1);
            switch (text)
            {
                case "X":
                    rabbit.rotationYZ(0.35);
                    break;
                case "Y":
                    rabbit.rotationXZ(0.35);
                    break;
                case "Z":
                    rabbit.rotationXY(0.35);
                    break;
                default:
                    break;
            }
            rabbit.move(center[0], center[1], center[2]);
            paintPanel.Invalidate();
        }

        private void rotationRight_Click(object sender, EventArgs e)
        {
            String text = null;
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    text = rb.Text;
                }
            }
            List<double> center = rabbit.getCenter();
            rabbit.move(center[0] * -1, center[1] * -1, center[2] * -1);
            switch (text)
            {
                case "X":
                    rabbit.rotationYZ(-0.35);
                    break;
                case "Y":
                    rabbit.rotationXZ(-0.35);
                    break;
                case "Z":
                    rabbit.rotationXY(-0.35);
                    break;
                default:
                    break;
            }
            rabbit.move(center[0], center[1], center[2]);
            paintPanel.Invalidate();
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            List<double> center = rabbit.getCenter();
            rabbit.move(center[0] * -1, center[1] * -1, center[2] * -1);
            rabbit.zoom(1.5, 1.5, 1.5);
            rabbit.move(center[0], center[1], center[2]);
            paintPanel.Invalidate();
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            List<double> center = rabbit.getCenter();
            rabbit.move(center[0] * -1, center[1] * -1, center[2] * -1);
            rabbit.zoom(0.6, 0.6, 0.6);
            rabbit.move(center[0], center[1], center[2]);
            paintPanel.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)=> Application.Exit();

        private void PaintProjectionDots(Matrix<double>m1,Matrix<double>m2)
        {
            Matrix<double>displayProjFront=rabbit.transformMatrix(projectionPanel,m1);
            Matrix<double>displayProjBack=rabbit.transformMatrix(projectionPanel,m2);
            for (int i = 0; i < displayProjFront.getRows()-1; i++)
            {
                int x1 = (int)displayProjFront[i,0] + 1;
                int y1 = (int)displayProjFront[i,1] + 1;
                int x2 = (int)displayProjFront[i+1,0] + 1;
                int y2 = (int)displayProjFront[i+1,1] + 1;
                g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }

            for (int j = 0; j < displayProjBack.getRows() - 1; j++)
            {
                int x1 = (int)displayProjBack[j, 0] + 1;
                int y1 = (int)displayProjBack[j, 1] + 1;
                int x2 = (int)displayProjBack[j+1, 0] + 1;
                int y2 = (int)displayProjBack[j + 1, 1] + 1;
                g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
            projectionPanel.Invalidate();
        }

        private void projectionX_Click(object sender, EventArgs e)
        {
            Matrix<double> matrix1 =rabbit.ProjectOnX().Item1;
            Matrix<double>matrix2=rabbit.ProjectOnX().Item2;
            PaintProjectionDots(matrix1,matrix2);
        }
    }
}
