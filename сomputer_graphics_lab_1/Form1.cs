using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace сomputer_graphics_lab
{
    public partial class Form1 : Form
    {
        Paint rabbit = new Paint();

        // Заполнение буферов глубины и кадра
        private void fillBuffers(List<List<int>> connections, Matrix<double> mainDots, Plane plane,
            DepthBuffer depthBuffer, FrameBuffer frameBuffer, Panel paintPanel, int color)
        {
            const int CNTDOTS = 200;
            Matrix<double> allDots = GeometryWorker.findSideDots(mainDots, connections, CNTDOTS);
            Matrix<double> displayAllDots = сomputer_graphics_lab.Paint.transformPrMatrix(paintPanel, allDots, plane);
            for (int i = 0; i < displayAllDots.getRows(); i++)
            {
                switch (plane)
                {
                    case Plane.X:
                        if (depthBuffer[(int)displayAllDots[i, 2], (int)displayAllDots[i, 1]] < displayAllDots[i, 0])
                        {
                            depthBuffer[(int)displayAllDots[i, 2], (int)displayAllDots[i, 1]] = displayAllDots[i, 0];
                            frameBuffer[(int)displayAllDots[i, 2], (int)displayAllDots[i, 1]] = color;
                        }
                        break;
                    case Plane.Y:
                        if (depthBuffer[(int)displayAllDots[i, 0], (int)displayAllDots[i, 2]] < displayAllDots[i, 1])
                        {
                            depthBuffer[(int)displayAllDots[i, 0], (int)displayAllDots[i, 2]] = displayAllDots[i, 1];
                            frameBuffer[(int)displayAllDots[i, 0], (int)displayAllDots[i, 2]] = color;
                        }
                        break;
                    case Plane.Z:
                        if (depthBuffer[(int)displayAllDots[i, 0], (int)displayAllDots[i, 1]] < displayAllDots[i, 2])
                        {
                            depthBuffer[(int)displayAllDots[i, 0], (int)displayAllDots[i, 1]] = displayAllDots[i, 2];
                            frameBuffer[(int)displayAllDots[i, 0], (int)displayAllDots[i, 1]] = color;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        // Отрисовка по буферу кадра
        private void drawByFrameBuffer(FrameBuffer frameBuffer, Graphics g) 
        {
            for (int i = 0; i < frameBuffer.getRows(); i++) 
            {
                for (int j = 0; j < frameBuffer.getCols(); j++) 
                {
                    SolidBrush brush = new SolidBrush(сomputer_graphics_lab.Paint.Colors[frameBuffer[i, j]]);
                    g.FillRectangle(brush, i, j, 1, 1);
                }
            }
        
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DepthBuffer dBuff = new DepthBuffer(paintPanel);
            FrameBuffer frameBuff = new FrameBuffer(paintPanel);

            fillBuffers(rabbit.connectionsFace, rabbit.face, Plane.Z, dBuff, frameBuff, paintPanel, 3);
            fillBuffers(rabbit.connectionsBody, rabbit.front, Plane.Z, dBuff, frameBuff, paintPanel, 1);
            fillBuffers(rabbit.connectionsBody, rabbit.back, Plane.Z, dBuff, frameBuff, paintPanel, 1);

            //fillBuffers(rabbit.connectionsFrontBack, rabbit.face, Plane.Z, dBuff, frameBuff, paintPanel, 1);

            drawByFrameBuffer(frameBuff, g);
        }

        private void FormProjections_Paint(object sender, PaintEventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();

        private void projectionX_Click(object sender, EventArgs e)
        {
            projectionPanel.Invalidate();
        }
    }
}
