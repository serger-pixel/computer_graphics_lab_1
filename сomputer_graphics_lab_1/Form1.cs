using System.Collections.Generic;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace сomputer_graphics_lab
{
    public partial class Form1 : Form
    {
        Paint rabbit = new Paint();

        // Отрисовка с невидимыми линиями
        private void paintDotsWithoutLines(List<List<int>> connections, Matrix<double> mainDots, Plane plane,
            DepthBuffer depthBuffer, FrameBuffer frameBuffer, Panel paintPanel)
        {
            Matrix<double> allDots = сomputer_graphics_lab.Paint.calculateDotsBetweenTwo(mainDots, connections);
            Matrix<int> displayAllDots = сomputer_graphics_lab.Paint.transformPrMatrix(paintPanel, allDots, plane);
            for (int i = 0; i < displayAllDots.getRows(); i++)
            {
                switch (plane)
                {
                    case Plane.X:
                        if (depthBuffer[i, 0] < displayAllDots[i, 0])
                        {
                            depthBuffer[i, 0] = displayAllDots[i, 0];
                            frameBuffer[displayAllDots[i, 2], displayAllDots[i, 1]] = 1;
                        }
                        break;
                    case Plane.Y:

                        break;
                    case Plane.Z:

                        break;
                    default:
                        break;
                }
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
            String text = null;
            foreach (Control ctrl in groupBox4.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    text = rb.Text;
                }
            }
            switch (text)
            {
                case "X":
                    paintDotsX(rabbit.connectionsBody, rabbit.front, g, pen);
                    paintDotsX(rabbit.connectionsBody, rabbit.back, g, pen);
                    paintDotsX(rabbit.connectionsFace, rabbit.face, g, pen);
                    paintConnectionsX(rabbit.connectionsFrontBack, rabbit.front, rabbit.back, g, pen);
                    break;
                case "Y":
                    paintDotsY(rabbit.connectionsBody, rabbit.front, g, pen);
                    paintDotsY(rabbit.connectionsBody, rabbit.back, g, pen);
                    paintDotsY(rabbit.connectionsFace, rabbit.face, g, pen);
                    paintConnectionsY(rabbit.connectionsFrontBack, rabbit.front, rabbit.back, g, pen);
                    break;
                case "Z":
                    paintDotsZ(rabbit.connectionsBody, rabbit.front, g, pen);
                    paintDotsZ(rabbit.connectionsBody, rabbit.back, g, pen);
                    paintDotsZ(rabbit.connectionsFace, rabbit.face, g, pen);
                    paintConnectionsZ(rabbit.connectionsFrontBack, rabbit.front, rabbit.back, g, pen);
                    break;
                default:
                    break;
            }
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

        private void button1_Click(object sender, EventArgs e) => Application.Exit();

        private void projectionX_Click(object sender, EventArgs e)
        {
            projectionPanel.Invalidate();
        }
    }
}
