using System.Collections.Generic;
using System.Drawing;

namespace сomputer_graphics_lab_1
{
    public partial class Form1 : Form
    {
        Paint rabbit = new Paint();

        private void paintDotsZ(List<List<int>> connections, Matrix<double> dots, Graphics g, Pen pen)
        {
            Matrix<double> displayMatrix = rabbit.transformPrXMatrix(paintPanel, dots, Plane.Z);
            for (int i = 0; i < connections.Count; i++)
            {
                int x1 = (int)displayMatrix[connections[i][0], 0] + 1;
                int y1 = (int)displayMatrix[connections[i][0], 1] + 1;
                int x2 = (int)displayMatrix[connections[i][1], 0] + 1;
                int y2 = (int)displayMatrix[connections[i][1], 1] + 1;
                g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        private void paintConnectionsZ(List<List<int>> connections, Matrix<double> dots1, Matrix<double> dots2, Graphics g, Pen pen)
        {
            Matrix<double> displayMatrix1 = rabbit.transformPrXMatrix(paintPanel, dots1, Plane.Z);
            Matrix<double> displayMatrix2 = rabbit.transformPrXMatrix(paintPanel, dots2, Plane.Z);
            for (int i = 0; i < connections.Count; i++)
            {
                int x1 = (int)displayMatrix1[connections[i][0], 0] + 1;
                int y1 = (int)displayMatrix1[connections[i][0], 1] + 1;
                int x2 = (int)displayMatrix2[connections[i][1], 0] + 1;
                int y2 = (int)displayMatrix2[connections[i][1], 1] + 1;
                g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        private void paintDotsY(List<List<int>> connections, Matrix<double> dots, Graphics g, Pen pen)
        {
            Matrix<double> displayMatrix = rabbit.transformPrXMatrix(paintPanel, dots, Plane.Y);
            for (int i = 0; i < connections.Count; i++)
            {
                int x1 = (int)displayMatrix[connections[i][0], 0] + 1;
                int z1 = (int)displayMatrix[connections[i][0], 2] + 1;
                int x2 = (int)displayMatrix[connections[i][1], 0] + 1;
                int z2 = (int)displayMatrix[connections[i][1], 2] + 1;
                g.DrawLine(pen, new Point(x1, z1), new Point(x2, z2));
            }
        }

        private void paintConnectionsY(List<List<int>> connections, Matrix<double> dots1, Matrix<double> dots2, Graphics g, Pen pen)
        {
            Matrix<double> displayMatrix1 = rabbit.transformPrXMatrix(paintPanel, dots1, Plane.Y);
            Matrix<double> displayMatrix2 = rabbit.transformPrXMatrix(paintPanel, dots2, Plane.Y);
            for (int i = 0; i < connections.Count; i++)
            {
                int x1 = (int)displayMatrix1[connections[i][0], 0] + 1;
                int z1 = (int)displayMatrix1[connections[i][0], 2] + 1;
                int x2 = (int)displayMatrix2[connections[i][1], 0] + 1;
                int z2 = (int)displayMatrix2[connections[i][1], 2] + 1;
                g.DrawLine(pen, new Point(x1, z1), new Point(x2, z2));
            }
        }

        private void paintDotsX(List<List<int>> connections, Matrix<double> dots, Graphics g, Pen pen)
        {
            Matrix<double> displayMatrix = rabbit.transformPrXMatrix(paintPanel, dots, Plane.X);
            for (int i = 0; i < connections.Count; i++)
            {
                int x1 = (int)displayMatrix[connections[i][0], 0] + 1;
                int z1 = (int)displayMatrix[connections[i][0], 2] + 1;
                int x2 = (int)displayMatrix[connections[i][1], 0] + 1;
                int z2 = (int)displayMatrix[connections[i][1], 2] + 1;
                g.DrawLine(pen, new Point(x1, z1), new Point(x2, z2));
            }
        }

        private void paintConnectionsX(List<List<int>> connections, Matrix<double> dots1, Matrix<double> dots2, Graphics g, Pen pen)
        {
            Matrix<double> displayMatrix1 = rabbit.transformPrXMatrix(paintPanel, dots1, Plane.X);
            Matrix<double> displayMatrix2 = rabbit.transformPrXMatrix(paintPanel, dots2, Plane.X);
            for (int i = 0; i < connections.Count; i++)
            {
                int z1 = (int)displayMatrix1[connections[i][0], 2] + 1;
                int y1 = (int)displayMatrix1[connections[i][0], 1] + 1;
                int z2 = (int)displayMatrix2[connections[i][1], 2] + 1;
                int y2 = (int)displayMatrix2[connections[i][1], 1] + 1;
                g.DrawLine(pen, new Point(z1, y1), new Point(z2, y2));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 5);
            paintDotsZ(rabbit.connectionsBody, rabbit.front, g, pen);
            paintDotsZ(rabbit.connectionsBody, rabbit.back, g, pen);
            paintDotsZ(rabbit.connectionsFace, rabbit.face, g, pen);
            paintConnectionsZ(rabbit.connectionsFrontBack, rabbit.front, rabbit.back, g, pen);
        }

        private void FormProjections_Paint(object sender, PaintEventArgs e) 
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 5);

            PaintProjectionDots(rabbit.ProjectOnX().Item1, rabbit.connectionsBody, g, pen);
            PaintProjectionDots(rabbit.ProjectOnX().Item2, rabbit.connectionsBody, g, pen);
            PaintProjectionDots(rabbit.ProjectOnX().Item1, rabbit.ProjectOnX().Item2, rabbit.connectionsFrontBack, g, pen);

        }

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            paintPanel.Paint += Form1_Paint;
            projectionPanel.Paint += FormProjections_Paint;
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


        private void PaintProjectionDots(Matrix<double> m, List<List<int>> connections, Graphics g, Pen pen) 
        {
            //Matrix<double> displayMatrix = rabbit.transformPrXMatrix(projectionPanel, m);
            //for (int i = 0; i < connections.Count; i++)
            //{
            //    int x1 = (int)displayMatrix[connections[i][0], 2] + 1;
            //    int y1 = (int)displayMatrix[connections[i][0], 1] + 1;
            //    int x2 = (int)displayMatrix[connections[i][1], 2] + 1;
            //    int y2 = (int)displayMatrix[connections[i][1], 1] + 1;
            //    g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            //}
        }

        private void PaintProjectionDots(Matrix<double>m1,Matrix<double>m2, List<List<int>> connections, Graphics g, Pen pen)
        {
            //Matrix<double>displayProjFront=rabbit.transformPrXMatrix(projectionPanel,m1);
            //Matrix<double>displayProjBack=rabbit.transformPrXMatrix(projectionPanel,m2);
            //for (int i = 0; i < connections.Count; i++)
            //{
            //    int x1 = (int)displayProjFront[connections[i][0], 2] + 1;
            //    int y1 = (int)displayProjFront[connections[i][0], 1] + 1;
            //    int x2 = (int)displayProjBack[connections[i][1], 2] + 1;
            //    int y2 = (int)displayProjBack[connections[i][1], 1] + 1;
            //    g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            //}
        }

        private void projectionX_Click(object sender, EventArgs e)
        {
            projectionPanel.Invalidate();
        }
    }
}
